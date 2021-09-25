/* eslint-disable no-undef */
const { Selector, ClientFunction } = require('testcafe')

// Selectors

function select (selector) {
  return Selector(selector).with({ boundTestRun: testController })
}

exports.page = {
  productSelection: function () {
    return select('#center_column > div.content_scene_cat > div > div > span').with({ boundTestRun: testController })
  }
}
