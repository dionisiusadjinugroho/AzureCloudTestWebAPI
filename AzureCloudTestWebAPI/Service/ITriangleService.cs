namespace AzureCloudTestWebAPI.Service
{
    public interface ITriangleService
    {
        decimal CornerDegrees(decimal a, decimal b, decimal c);
        string GetCategoryTriangle(decimal sideA = 0, decimal sideB = 0, decimal sideC = 0);
    }
}