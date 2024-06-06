// Copyright (c) Microsoft. All rights reserved.

import { IChatMessage } from '../../../libs/models/ChatMessage';
import { ChatState } from './ChatState';

export type Conversations = Record<string, ChatState>;

export interface ConversationsState {
    conversations: Conversations;
    selectedId: string;
}

export const initialState: ConversationsState = {
    conversations: {},
    selectedId: '',
};

export interface UpdateConversationPayload {
    id: string;
    messages: IChatMessage[];
}

export interface ConversationTitleChange {
    id: string;
    newTitle: string;
}

export interface ConversationInputChange {
    id: string;
    newInput: string;
}

export interface ConversationSystemDescriptionChange {
    id: string;
    newSystemDescription: string;
}

export interface UpdatePluginStatePayload {
    id: string;
    pluginName: string;
    newState: boolean;
}
