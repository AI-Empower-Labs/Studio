import { Button, Text, Tooltip, makeStyles } from '@fluentui/react-components';
import { useCallback } from 'react';
import { UserFeedback } from '../../../libs/models/ChatMessage';
import { useAppDispatch, useAppSelector } from '../../../redux/app/hooks';
import { RootState } from '../../../redux/app/store';
import { updateMessageProperty } from '../../../redux/features/conversations/conversationsSlice';
import { ThumbDislike16, ThumbLike16 } from '../../shared/BundledIcons';

const useClasses = makeStyles({
    root: {
        display: 'flex',
        'place-content': 'flex-end',
        alignItems: 'center',
    },
});

interface IUserFeedbackProps {
    messageIndex: number;
}

export const UserFeedbackActions: React.FC<IUserFeedbackProps> = ({ messageIndex }) => {
    const classes = useClasses();

    const dispatch = useAppDispatch();
    const { selectedId } = useAppSelector((state: RootState) => state.conversations);

    const onUserFeedbackProvided = useCallback(
        (positive: boolean) => {
            dispatch(
                updateMessageProperty({
                    chatId: selectedId,
                    messageIdOrIndex: messageIndex,
                    property: 'userFeedback',
                    value: positive ? UserFeedback.Positive : UserFeedback.Negative,
                    frontLoad: true,
                }),
            );
        },
        [dispatch, messageIndex, selectedId],
    );

    return (
        <div className={classes.root}>
            <Text color="gray" size={200}>
                AI-generated content may be incorrect
            </Text>
            <Tooltip content={'Like bot message'} relationship="label">
                <Button
                    icon={<ThumbLike16 />}
                    appearance="transparent"
                    aria-label="Edit"
                    onClick={() => {
                        onUserFeedbackProvided(true);
                    }}
                />
            </Tooltip>
            <Tooltip content={'Dislike bot message'} relationship="label">
                <Button
                    icon={<ThumbDislike16 />}
                    appearance="transparent"
                    aria-label="Edit"
                    onClick={() => {
                        onUserFeedbackProvided(false);
                    }}
                />
            </Tooltip>
        </div>
    );
};
