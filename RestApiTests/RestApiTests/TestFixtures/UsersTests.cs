using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using RestApiTests.Models.Create;
using RestApiTests.Models.Users;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTests.TestFixtures
{
    internal class UsersTests
    {
        [Test] // test zde spouštíme jako debug test (Aspon první fáze)
        public void GetUsers()
        {
            var endpoint = "https://reqres.in/api/users";
            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint);
            request.Method = Method.Get;

            var response = client.Execute(request);
            var responseBody = 
                JsonConvert.DeserializeObject<UsersResponse>(response.Content);

            // Verify (fluent package)
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            responseBody.page.Should().Be(1);
            responseBody.data.Should().NotBeNullOrEmpty();

                
        }

        [Test] 
        public void CreateUsers()
        {
            var endpoint = "https://reqres.in/api/users";
            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint);
            request.Method = Method.Post;

            var payload = new UsersCreateRequest
            {
                name = "John",
                job = "Engineer"
            };

            request.AddJsonBody(payload);   

            var response = client.Execute(request);
            var responseBody =
                JsonConvert.DeserializeObject<UsersCreateResponse>(response.Content);

            // Verify (fluent package)
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);
            responseBody.id.Should().NotBeNullOrEmpty();

        }

    }
}
