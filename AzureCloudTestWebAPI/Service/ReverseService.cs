using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCloudTestWebAPI.Service
{
    public class ReverseService : IReverseService
    {
        public string Reverse(string input)
        {
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
