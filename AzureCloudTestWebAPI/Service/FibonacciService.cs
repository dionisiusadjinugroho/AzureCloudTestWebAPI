using AzureCloudTestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCloudTestWebAPI.Service
{
    public class FibonacciService : IFibonacciService
    {
        public decimal CalculateFibonacci(int n)
        {
            var Fn = (Math.Pow((1 + Math.Sqrt(5)), (double)n) - Math.Pow((1 - Math.Sqrt(5)), (double)n)) / (Math.Pow(2, (double)n) * Math.Sqrt(5));
            return Convert.ToDecimal(Fn);
        }

        public List<Fibonacci> FibonacciSequence(int fromN = 0, int toN = 0)
        {
            int seqStart = 0;
            int seqEnd = 0;
            var listFb = new List<Fibonacci>();
            if (fromN > toN)
            {
                seqStart = toN;
                seqEnd = fromN;
            }
            else
            {
                seqStart = fromN;
                seqEnd = toN;
            }

            for (int i = seqStart; i <= seqEnd; i++)
            {
                var Fn = CalculateFibonacci(i);
                listFb.Add(new Fibonacci() { Fn = i.ToString(), Number = Fn });
            }
            return listFb;
        }
    }
}
