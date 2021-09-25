/* eslint-disable no-unused-vars */
/* eslint-disable no-undef */
const { Given } = require('cucumber')
const header = require('../support/pages/header.page')

Given('I am on the test automation practice site', async () => {
  await testController.navigateTo('http://automationpractice.com/index.php')
  // Hardcode URL for demo
})

Given('I want to login to the site', async () => {
  await testController.navigateTo('http://automationpractice.com/index.php')
  // Hardcode URL for demo
  await testController.click(header.page.login())
})