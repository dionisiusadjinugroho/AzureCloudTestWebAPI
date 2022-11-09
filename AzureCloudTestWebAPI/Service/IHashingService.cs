using AzureCloudTestWebAPI.Models;

namespace AzureCloudTestWebAPI.Service
{
    public interface IHashingService
    {
        Hashing MD5Hashing(string input);
    }
}