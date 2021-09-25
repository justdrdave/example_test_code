/* eslint-disable no-undef */
const { Selector } = require('testcafe')

// Selectors

function select (selector) {
  return Selector(selector).with({ boundTestRun: testController })
}

exports.page = {
  email: function () {
    return select('#email')
  },
  password: function () {
    return Selector('#passwd')
  },
  loginButton: function () {
    return select('#SubmitLogin')
  }
}
