using TestWebApp.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestWebApp.Tests
{
    public class TestWeb : IClassFixture<WebApplicationFactory<TestWebApp.Startup>>
    {
        private readonly WebApplicationFactory<TestWebApp.Startup> _factory;

        public TestWeb(WebApplicationFactory<TestWebApp.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Post_EndpointsReturnJsonAndEqualsWithSummator()
        {
            // Arrange
            var client = _factory.CreateClient();
            /*var json = "{\"a\":2,\"b\":3}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");*/

            // Act
            /*var request = client.PostAsync("/Summa/PostJson", content);*/

            // Assert
            /*Assert.Equal("{\"c\":5}",
                 request.Result.ToString());*/
            // Arrange
            /* var client = _factory.CreateClient();
             var json = "{\"a\":2,\"b\":3}";
             var content = new StringContent(json, Encoding.UTF8, "application/json");

             // Act
             var request = client.PostAsync(url, content);

             // Assert
             Assert.Equal("{\"c\":5}",
                 request.Result.ToString());*/
            // The endpoint or route of the controller action.

            var json = "{\"a\":2,\"b\":3}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            
            // Act
            var httpRequest = client.PostAsync("/Summa/PostJson", content);
            string httpResponse = await httpRequest.Result.Content.ReadAsStringAsync();
            
            // Must be successful.
            Assert.Equal("{\"c\":5}", httpResponse);
        }
    }
}
