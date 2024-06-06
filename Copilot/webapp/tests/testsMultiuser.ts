// Copyright (c) Microsoft. All rights reserved.

import { expect } from '@playwright/test';
import * as util from './utils';

/*
Summary: Tests the Multiuser feature of Copilot Chat. Specifically if a user can 
generate a chatid for their chat session and then if another user can join that same chat session.
*/
export async function shareAndJoinChatSessionTest(page) {
    const userAccount1 = process.env.REACT_APP_TEST_USER_ACCOUNT1 as string;
    const password1 = process.env.REACT_APP_TEST_USER_PASSWORD1 as string;
    const userAccount2 = process.env.REACT_APP_TEST_USER_ACCOUNT2 as string;
    const password2 = process.env.REACT_APP_TEST_USER_PASSWORD2 as string;

    await util.loginHelper(page, userAccount1, password1);
    await util.createNewChat(page);

    // Need to enable live chat session sharing to access the share button
    await page.getByTestId('userSettingsButton').click();
    await page.getByTestId('settingsMenuItem').click();
    await page.getByTestId('advancedSettingsFoldup').click();
    await page.getByTestId('Live Chat Session Sharing').click();
    await page.getByTestId('userSettingsCloseButton').click();

    await page.getByTestId('shareButton').click();
    await page.getByTestId('inviteOthersMenuItem').click();

    const labelByID = await page.getByTestId('invitationDialogChatIDLabel');
    const chatId = await labelByID.textContent();
    await page.getByTestId('invitationDialogCloseButton').click();

    await page.getByTestId('userSettingsButton').click();
    await page.getByTestId('logOutMenuButton').click();

    const usernameToLowerCase = userAccount1.toLowerCase();
    const locatorVal = ('[data-test-id="' + usernameToLowerCase + '"]') as string;
    await page.locator(locatorVal).click();

    // Login with the second user account
    await util.loginHelperAnotherUser(page, userAccount2, password2);

    // Need to enable live chat session sharing to access the join button
    await page.getByTestId('userSettingsButton').click();
    await page.getByTestId('settingsMenuItem').click();
    await page.getByTestId('advancedSettingsFoldup').click();
    await page.getByTestId('Simplified Chat Experience').click();
    await page.getByTestId('Live Chat Session Sharing').click();
    await page.getByTestId('userSettingsCloseButton').click();

    await page.getByTestId('createNewConversationButton').click();
    await page.getByTestId('joinABotMenuItem').click();
    await page.getByTestId('enterChatIDLabel').fill(chatId as string);

    await page.getByTestId('joinChatButton').click();

    await page.waitForTimeout(util.ChatStateChangeWait);

    await page.getByTestId('chatParticipantsView').click();
    const numPeople = await page.getByTestId('chatParticipantsView').textContent();
    await expect(numPeople).toEqual('+2');

    await util.postUnitTest(page);
}
