// Copyright (c) Microsoft. All rights reserved.

import { useMsal } from '@azure/msal-react';
import { Body1, Spinner, Title3 } from '@fluentui/react-components';
import { FC, useEffect, useMemo, useState } from 'react';
import { renderApp } from '../../index';
import { AuthHelper } from '../../libs/auth/AuthHelper';
import { NetworkErrorMessage } from '../../libs/services/BaseService';
import { MaintenanceService, MaintenanceStatus } from '../../libs/services/MaintenanceService';
import { useAppDispatch, useAppSelector } from '../../redux/app/hooks';
import { RootState } from '../../redux/app/store';
import { setMaintenance } from '../../redux/features/app/appSlice';
import { useSharedClasses } from '../../styles';

interface IData {
    onBackendFound: () => void;
}

export const BackendProbe: FC<IData> = ({ onBackendFound }) => {
    const classes = useSharedClasses();
    const dispatch = useAppDispatch();
    const { isMaintenance } = useAppSelector((state: RootState) => state.app);
    const maintenanceService = useMemo(() => new MaintenanceService(), []);
    const { instance, inProgress } = useMsal();

    const [model, setModel] = useState<MaintenanceStatus | null>(null);

    useEffect(() => {
        const timer = setInterval(() => {
            const onBackendFoundWithAuthCheck = () => {
                if (!AuthHelper.getAuthConfig()) {
                    // if we don't have the auth config, re-render the app:
                    renderApp();
                } else {
                    // otherwise, we can load as normal
                    onBackendFound();
                }
            };

            AuthHelper.getSKaaSAccessToken(instance, inProgress)
                .then((token) =>
                    maintenanceService
                        .getMaintenanceStatus(token)
                        .then((data) => {
                            // Body has payload. This means the app is in maintenance
                            setModel(data);
                        })
                        .catch((e: any) => {
                            if (e instanceof Error && e.message.includes(NetworkErrorMessage)) {
                                // a network error was encountered, so we should probe until we find the backend:
                                return;
                            }

                            // JSON Exception since response has no body. This means app is not in maintenance.
                            dispatch(setMaintenance(false));
                            onBackendFoundWithAuthCheck();
                        }),
                )
                .catch(() => {
                    // Ignore - we'll retry on the next interval
                });
        }, 3000);

        return () => {
            clearInterval(timer);
        };
    }, [dispatch, maintenanceService, onBackendFound, instance, inProgress]);

    return (
        <>
            {isMaintenance ? (
                <div className={classes.informativeView}>
                    <Title3>{model?.title ?? 'Site undergoing maintenance...'}</Title3>
                    <Spinner />
                    <Body1>
                        {model?.message ?? 'Planned site maintenance is underway.  We apologize for the disruption.'}
                    </Body1>
                    <Body1>
                        <strong>
                            {model?.note ??
                                "Note: If this message doesn't resolve after a significant duration, refresh the browser."}
                        </strong>
                    </Body1>
                </div>
            ) : (
                <div className={classes.informativeView}>
                    <Title3>Connecting...</Title3>
                    <Spinner />
                </div>
            )}
        </>
    );
};
