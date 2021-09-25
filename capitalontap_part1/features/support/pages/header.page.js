/* eslint-disable no-undef */
const { Selector, ClientFunction } = require('testcafe')

// Selectors

function select (selector) {
  return Selector(selector).with({ boundTestRun: testController })
}

exports.page = {
  selectHeaderLink: function (link) {
    if (String(link).valueOf() === String('Dresses').valueOf()) {
      return select('#block_top_menu > ul > li:nth-child(2) > a')
    }
    if (String(link).valueOf() === String('Summer Dresses').valueOf()) {
      return select('#block_top_menu > ul > li:nth-child(2) > ul > li:nth-child(3) > a')
    }
  },
  login: function () {
    return select('#header > div.nav > div > div > nav > div.header_user_info > a')
  },
  user: function () {
    return select('#header > div.nav > div > div > nav > div:nth-child(1) > a > span')
  }
}
