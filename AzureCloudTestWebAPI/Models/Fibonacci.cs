using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCloudTestWebAPI.Models
{
    public class Fibonacci
    {
        public string Fn { get; set; }
        public decimal Number { get; set; }
    }

    public class FibonacciInput
    {
        public int From { get; set; }
        public int To { get; set; }
    }
}
