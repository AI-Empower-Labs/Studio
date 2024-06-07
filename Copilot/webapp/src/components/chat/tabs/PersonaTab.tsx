// Copyright (c) Microsoft. All rights reserved.

import * as React from 'react';
import { useChat } from '../../../libs/hooks/useChat';
import { useAppDispatch, useAppSelector } from '../../../redux/app/hooks';
import { RootState } from '../../../redux/app/store';
import { editConversationSystemDescription } from '../../../redux/features/conversations/conversationsSlice';
import { MemoryBiasSlider } from '../persona/MemoryBiasSlider';
import { PromptEditor } from '../persona/PromptEditor';
import { TabView } from './TabView';

export const PersonaTab: React.FC = () => {
    const chat = useChat();
    const dispatch = useAppDispatch();

    const { conversations, selectedId } = useAppSelector((state: RootState) => state.conversations);
    const chatState = conversations[selectedId];

    const [shortTermMemory, setShortTermMemory] = React.useState<string>('');
    const [longTermMemory, setLongTermMemory] = React.useState<string>('');

    React.useEffect(() => {
        if (!conversations[selectedId].disabled) {
            void Promise.all([
                chat.getSemanticMemories(selectedId, 'WorkingMemory').then((memories) => {
                    setShortTermMemory(memories.join('\n'));
                }),
                chat.getSemanticMemories(selectedId, 'LongTermMemory').then((memories) => {
                    setLongTermMemory(memories.join('\n'));
                }),
            ]);
        }
        // We don't want to have chat as one of the dependencies as it will cause infinite loop.
        // eslint-disable-next-line react-hooks/exhaustive-deps
    }, [selectedId]);

    return (
        <TabView title="Persona" learnMoreDescription="personas" learnMoreLink=" https://aka.ms/sk-intro-to-personas ">
            <PromptEditor
                title="Meta Prompt"
                chatId={selectedId}
                prompt={chatState.systemDescription}
                isEditable={true}
                info="The prompt that defines the chat bot's persona."
                modificationHandler={async (newSystemDescription: string) => {
                    await chat
                        .editChat(selectedId, chatState.title, newSystemDescription, chatState.memoryBalance)
                        .finally(() => {
                            dispatch(
                                editConversationSystemDescription({
                                    id: selectedId,
                                    newSystemDescription: newSystemDescription,
                                }),
                            );
                        });
                }}
            />
            <PromptEditor
                title="Short Term Memory"
                chatId={selectedId}
                prompt={`<label>: <details>\n${shortTermMemory}`}
                isEditable={false}
                info="Extract information for a short period of time, such as a few seconds or minutes. It should be useful for performing complex cognitive tasks that require attention, concentration, or mental calculation."
            />
            <PromptEditor
                title="Long Term Memory"
                chatId={selectedId}
                prompt={`<label>: <details>\n${longTermMemory}`}
                isEditable={false}
                info="Extract information that is encoded and consolidated from other memory types, such as working memory or sensory memory. It should be useful for maintaining and recalling one's personal identity, history, and knowledge over time."
            />
            <MemoryBiasSlider />
        </TabView>
    );
};
