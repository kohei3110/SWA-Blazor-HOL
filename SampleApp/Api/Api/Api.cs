using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.NetworkInformation;

using Common;

namespace Api
{
    public static class Api
    {
        [FunctionName("Api")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "products")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            Product product = new Product
            {
                ID = 111,
                Name = "Product 111",
                Description = "製品の説明",
                Quantity = 1
            };
            return new OkObjectResult(product);

        }
    }
}

