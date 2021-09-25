/* eslint-disable no-unused-vars */
/* eslint-disable no-undef */
const { When } = require('cucumber')
const header = require('../support/pages/header.page')
const login = require('../support/pages/login.page')

When('I select {string} from the {string} options', async (itemSubType, itemType) => {
  await testController.hover(header.page.selectHeaderLink(itemType))
  await testController.click(header.page.selectHeaderLink(itemSubType))
})

When('I log in with {string} and {string}', async (email, password) => {
  if (email == 'validEmail') {
    await testController.typeText(login.page.email(), 'david_loz_2000@yahoo.com')
  }
  if (password == 'validPassword') {
    await testController.typeText(login.page.password(), '1234$abcd')
  }
  // Have hardcoded emails for now, would use discriptive names for different logins in feature files and retreave form a login details file
  await testController.click(login.page.loginButton())
})