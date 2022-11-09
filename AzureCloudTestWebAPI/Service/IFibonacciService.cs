using AzureCloudTestWebAPI.Models;
using System.Collections.Generic;

namespace AzureCloudTestWebAPI.Service
{
    public interface IFibonacciService
    {
        decimal CalculateFibonacci(int n);
        List<Fibonacci> FibonacciSequence(int fromN = 0, int toN = 0);
    }
}