using System.Text.Json;
using RestSharp;

public class ProductManagementService : IProductManagementService
{

    private readonly RestClient restClient;
    public ProductManagementService(RestClient restClient)
    {
        this.restClient = restClient;
        restClient.Timeout = -1;
    }

    public List<ProductDto> GetProducts()
    {
        var request = new RestRequest("/api/ProductManagement", Method.GET);
        IRestResponse response = restClient.Execute(request);
        var products = JsonSerializer.Deserialize<List<ProductDto>>(response.Content);
        return products;
    }

    public ResultDto UpdateName(UpdateProductDto updateProduct)
    {
        var request = new RestRequest($"/api/ProductManagement", Method.PUT);
        request.AddHeader("Content-Type", "application/json");
        string serializeModel = JsonSerializer.Serialize(updateProduct);
        request.AddParameter("application/json", serializeModel, ParameterType.RequestBody);
        IRestResponse response = restClient.Execute(request);
        return GetResponseStatusCode(response);
    }


    private static ResultDto GetResponseStatusCode(IRestResponse response)
    {
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
            return new ResultDto(false);
        }
        else
        {
            return new ResultDto(false, response.ErrorMessage);
        }
    }


}