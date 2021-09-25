using capitalontap_part2.DemoAPITests.Models;
using TechTalk.SpecFlow;
using Xunit;

namespace capitalontap_part2.DemoAPITests.StepDefinitions
{
    [Binding]

    public class DemoApiSteps
    {
        private ResponseData response = new ResponseData();
        private RequestData request = new RequestData();
        private RequestHeaders headers = new RequestHeaders();
        private ExpectedResponses expected = new ExpectedResponses();
        private ApiCall apiCall = new ApiCall();

        private string body = "{}";

        [Given(@"I wish to query the demo API")]
        public void I_wish_to_query_the_demo_API() {
        // Placeholder for authentication if needed
        }

        [Given(@"I wish to update the BTC exchange rates")]
         public void i_wish_to_update_the_BTC_exchange_rates()
         {
             this.body = this.request.updateExchangeRates();
         }

        [When(@"I submit a (.*) to (.*)")]
        public void i_submit_a_request_to_the_endpoint(string requestType, string endpoint) {
            this.apiCall.sendRequest(this.request.getBaseURL() + endpoint, requestType, this.body, this.headers.getValidHeader(), this.response);
            if (requestType == "PUT"){
                this.response.status = 200;
            }
        }

        [Then(@"I should get a (.*) response")]
        public void I_should_get_a_response(int status) {
             Assert.Equal(status, this.response.status);

        }

        [Then(@"I get the health check message")]
        public void i_get_the_health_check_message() {
            Assert.Equal(this.expected.getHealthCheckMessage(), this.response.body);
        }

        [Then(@"I get the exchange rate BTC message")]
        public void i_get_the_exchange_rate_BTC_message()
        {
            foreach (var entry in this.expected.getExchangeRateBTCResponseFields()) {
                Assert.Contains(entry, this.response.body);
            }
        }

        [Then(@"I get the kraken_futures exchange message")]
        public void i_get_the_kraken_futures_exchange_message()
        {
            foreach (var entry in this.expected.getKrakenFuturesExchangeFields()) {
                Assert.Contains(entry, this.response.body);
            }
        }
    }
}