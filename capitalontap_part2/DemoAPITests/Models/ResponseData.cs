using System.Collections.Generic;

namespace capitalontap_part2.DemoAPITests.Models
{
    public class ResponseData
    {
        public int status { get; set; }
        public string body { get; set; }
        public Dictionary<string, string> header = new Dictionary<string, string>();
    }
}