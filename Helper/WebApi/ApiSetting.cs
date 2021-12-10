using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class ApiSetting
    {
        public string ApiUrl { get; set; }
        public string ApiPrefix { get; set; }
        public List<ApiController> ApiControllers { get; set; }
    }
}
