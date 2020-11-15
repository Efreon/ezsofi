using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using RESTApiWs.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RESTApiWs.IntegrationTests
{
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        // this builds and runs the application 
        private readonly WebApplicationFactory<Startup> factory;

        public IntegrationTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Fact]
        public async Task MainPageLoadsSuccessfully()
        {
            var responseMessage = await factory.CreateClient().GetAsync("/");

            responseMessage.EnsureSuccessStatusCode();
        }

        // this needs to be async
        // tests for proper input
        [Fact]
        public async Task Doubling_ReturnsResult()
        {
            // arrange
            var expected = 10;

            // act
            var response = await factory.CreateClient().GetAsync("api/home/doubling?input=5");
            var data = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Response>(data);
            // var result = JsonConvert.DeserializeObject < Dictionary<string, int >> (data);
            // result.TryGetValue("result", out int actual);

            // assert
            // check if it is a succes or not
            response.EnsureSuccessStatusCode();

            // check for the returned value
            // Assert.Equal(expected, actual);
            Assert.Equal(expected, result.Result);
        }

        [Fact]
        public async Task DoUntil_Multiply_ReturnsResult()
        {
            // arrange
            var expected = 120;
            var toSend = JsonConvert.SerializeObject(new BodyData { Until = 5 });
            var httpContent = new StringContent(toSend, Encoding.UTF8, "application/json");

            // act
            var response = await factory.CreateClient().PostAsync("api/home/dountil/multiply", httpContent);
            var data = await response.Content.ReadAsStringAsync();


            var result = JsonConvert.DeserializeObject<Dictionary<string, int>>(data);
            result.TryGetValue("result", out int actual);

            // assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, actual);
        }

        // Test 
        //[Fact]
        //public async Task Greeter_ReturnsResult()
        //{

        //    var expected = "Please provide an input!";

        //    var response = await factory.CreateClient().GetAsync("api/home/doubling");
        //    var data = await response.Content.ReadAsStringAsync();

        //    var result = JsonConvert.DeserializeObject < Dictionary<string, string >> (data);
        //    result.TryGetValue("result", out string actual);

        //    // check if it is a succes or not
        //    // response.EnsureSuccessStatusCode();

        //    // check for the returned value
        //    Assert.Equal(expected, actual);
        //}
    }
}
