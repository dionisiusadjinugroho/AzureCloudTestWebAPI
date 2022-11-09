using AzureCloudTestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AzureCloudTestWebAPI.Service
{
    public class HashingService : IHashingService
    {
        public Hashing MD5Hashing(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                var hashString = Convert.ToBase64String(hashBytes);
                return new Hashing() { Algorithm = "MD5", Value = hashString };
            }
        }
    }
}
