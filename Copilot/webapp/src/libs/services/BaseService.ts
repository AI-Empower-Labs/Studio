// Copyright (c) Microsoft. All rights reserved.

import { URLSearchParams } from 'url';
import { Plugin } from '../../redux/features/plugins/PluginsState';

interface ServiceRequest {
    commandPath: string;
    method?: string;
    body?: unknown;
    query?: URLSearchParams;
}

const noResponseBodyStatusCodes = [202, 204];

export const BackendServiceUrl =
    process.env.REACT_APP_BACKEND_URI == null || process.env.REACT_APP_BACKEND_URI.trim() === ''
        ? window.origin
        : process.env.REACT_APP_BACKEND_URI;
export const NetworkErrorMessage = '\n\nPlease check that your backend is running and that it is accessible by the app';

export class BaseService {
    constructor(protected readonly serviceUrl: string = BackendServiceUrl) {}

    protected readonly getResponseAsync = async <T>(
        request: ServiceRequest,
        accessToken?: string,
        enabledPlugins?: Plugin[],
    ): Promise<T> => {
        const { commandPath, method, body, query } = request;

        const isFormData = body instanceof FormData;

        const headers = new Headers(
            accessToken
                ? {
                      Authorization: `Bearer ${accessToken}`,
                  }
                : undefined,
        );

        if (!isFormData) {
            headers.append('Content-Type', 'application/json');
        }

        if (enabledPlugins && enabledPlugins.length > 0) {
            // For each enabled plugin, pass its auth information as a customer header
            // to the backend so the server can authenticate to the plugin
            for (const plugin of enabledPlugins) {
                headers.append(`x-sk-copilot-${plugin.headerTag}-auth`, plugin.authData ?? '');
            }
        }

        try {
            const requestUrl = new URL(commandPath, this.serviceUrl);
            if (query) {
                requestUrl.search = `?${query.toString()}`;
            }

            const response = await fetch(requestUrl, {
                method: method ?? 'GET',
                body: isFormData ? body : JSON.stringify(body),
                headers,
            });

            if (!response.ok) {
                if (response.status === 504) {
                    throw Object.assign(new Error('The request timed out. Please try sending your message again.'));
                }

                const responseText = await response.text();
                const responseDetails = responseText.split('--->');
                const errorDetails =
                    responseDetails.length > 1
                        ? `${responseDetails[0].trim()} ---> ${responseDetails[1].trim()}`
                        : responseDetails[0];
                const errorMessage = `${response.status}: ${response.statusText}${errorDetails}`;

                throw Object.assign(new Error(errorMessage));
            }

            return (noResponseBodyStatusCodes.includes(response.status) ? {} : await response.json()) as T;
        } catch (e: any) {
            let isNetworkError = false;
            if (e instanceof TypeError) {
                // fetch() will reject with a TypeError when a network error is encountered.
                isNetworkError = true;
            }
            throw Object.assign(new Error(`${e as string} ${isNetworkError ? NetworkErrorMessage : ''}`));
        }
    };
}
