/* eslint-disable no-unused-vars */
/* eslint-disable no-undef */
const { Then } = require('cucumber')

const header = require('../support/pages/header.page')
const products = require('../support/pages/productResults.page')

Then('I should be shown all {string}', async (type) => {
  await testController.expect(products.page.productSelection().innerText).contains(type)
})

Then('I should be logged in', async () => {
  await testController.expect(header.page.user().innerText).contains("David Loz")
})