using System.Collections.Generic;

namespace MVCDemo.Models
{
    public class DemoViewModel
    {
        public int ViewDataCount { get; set; }
        public List<string> ViewDataKeys { get; set; }
        public List<object> ViewDataValues { get; set; }
    }
}
