Feature: Demo API Tests

  As an automation tester
  I want to provide a couple of working tests
  So that I can demonstrate the automation working
 
  Scenario: Endpoint health check
    Given I wish to query the demo API
    When I submit a GET to /ping
    Then I should get a 200 response
    And I get the health check message

  Scenario: Get the exchange rate BTC
    Given I wish to query the demo API
    When I submit a GET to /exchanges/btc_exchange
    Then I should get a 200 response
    And I get the exchange rate BTC message

  Scenario: Get the derivatives information for the kraken_futures exchange
    Given I wish to query the demo API
    When I submit a GET to /derivatives/exchanges/kraken_futures
    Then I should get a 200 response
    And I get the kraken_futures exchange message

  Scenario: Creating a PUT request to update the price of btc and utilising mocks/stubs to return a OK response
    Given I wish to update the BTC exchange rates
    When I submit a PUT to /exchanges/btc_exchange
    Then I should get a 200 response
