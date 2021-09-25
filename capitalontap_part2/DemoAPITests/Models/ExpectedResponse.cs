using System.Collections.Concurrent;
using System.Collections.Generic;

namespace capitalontap_part2.DemoAPITests.Models
{
    public class ExpectedResponses
    {
        Dictionary<string, List<string>> keyFields = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> commonFields = new Dictionary<string, List<string>>();

        public string getHealthCheckMessage() {
            return "{\"gecko_says\":\"(V3) To the Moon!\"}";
        }

        public List<string> getExchangeRateBTCResponseFields(){
            return new List<string> {"{\"name\":\"Btc Exchange\"",  "\"year_established\":2018",  "\"country\":\"Lithuania\"",  "\"description\":null",  "\"url\":\"https://www.btc-exchange.com/\"", "\"image\":\"https://assets.coingecko.com/markets/images/336/small/vxfqIwr4S18Y9gD9GAnTXXl33GgoWKCH7Q.png?1547029157\"", "\"facebook_url\":\"\"", "\"reddit_url\":\"\"", "\"telegram_url\":\"\"", "\"slack_url\":\"\"", "\"other_url_1\":\"\"", "\"other_url_2\":\"\"", "\"twitter_handle\":\"\"","\"has_trading_incentive\":false", "\"centralized\":true", "\"public_notice\":\"\"", "\"alert_notice\":\"\"", "\"trust_score\":null", "\"trust_score_rank\":", "\"trade_volume_24h_btc\":", "\"trade_volume_24h_btc_normalized\":", "\"tickers\":[{\"base\":\"BTC\",\"target\":\"EUR\",\"market\":{\"name\":\"Btc Exchange\",\"identifier\":\"btc_exchange\",\"has_trading_incentive\":false},\"last\":", "\"volume\":", "\"converted_last\":{\"btc\":", "\"eth\":", "\"usd\":", "},\"converted_volume\":{\"btc\":", "\"eth\":", "\"usd\":", "},\"trust_score\":null,\"bid_ask_spread_percentage\":null,\"timestamp\":", "\"last_traded_at\":", "\"last_fetch_at\":", "\"is_anomaly\":false,\"is_stale\":false,\"trade_url\":\"https://www.btc-exchange.com/\",\"token_info_url\":null,\"coin_id\":\"bitcoin\"},{\"base\":\"ETH\",\"target\":\"EUR\",\"market\":{\"name\":\"Btc Exchange\",\"identifier\":\"btc_exchange\",\"has_trading_incentive\":false},", "\"last\":", "\"volume\":", "\"converted_last\":{\"btc\":", "\"eth\":", "\"usd\":", "},\"converted_volume\":{\"btc\":", "\"eth\":", "\"usd\":", "},\"trust_score\":null,\"bid_ask_spread_percentage\":null,\"timestamp\":", "\"last_traded_at\":", "\"last_fetch_at\":", "\"is_anomaly\":false,\"is_stale\":false,\"trade_url\":\"https://www.btc-exchange.com/\",\"token_info_url\":null,\"coin_id\":\"ethereum\"}],\"status_updates\":[]}"};
        }

        public List<string> getKrakenFuturesExchangeFields(){
            return new List<string> {"\"trade_volume_24h_btc\":",  "\"number_of_perpetual_pairs\":", "\"number_of_futures_pairs\":", "\"image\":\"https://assets.coingecko.com/markets/images/426/small/NX0D_EiD_400x400.jpg?1560770269\",\"year_established\":2019,\"country\":\"United States\",\"description\":\"Kraken Futures was previously known as Crypto Facilities. Crypto Facilities Ltd is an FCA authorised cryptocurrency derivatives platform based in London. Crypto Facilities became a part of the Kraken group of companies and rebranded to Kraken Futures in February 2019. They offer up to 50x leverage on 5 trading pairs. The most popular trading pair is the XBTUSD pair. \",\"url\":\"https://futures.kraken.com/\"}"};
        }
    }
}