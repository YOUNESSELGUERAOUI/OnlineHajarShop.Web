using NUnit.Framework;
using RestSharp;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var client = new RestClient("https://localhost:44300/api/product/AddNewProductList");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "f857392e-6fe0-40c1-99c9-6aed7c7c92ad");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "[\n    {\n        \"productId\": 5,\n        \"title\": \"New product 5\",\n        \"description\": \"Desc new product\",\n        \"brandId\": 12,\n        \"categoryId\": 143\n    },\n    {\n        \"productId\": 6,\n        \"title\": \"New product 6\",\n        \"description\": \"Desc new product\",\n        \"brandId\": 22,\n        \"categoryId\": 143\n    },\n    {\n        \"productId\": 7,\n        \"title\": \"New product 7\",\n        \"description\": \"Desc new product\",\n        \"brandId\": 32,\n        \"categoryId\": 143\n    }\n]", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Assert.Pass();
        }
    }
}