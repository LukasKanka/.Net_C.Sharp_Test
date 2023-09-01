using Newtonsoft.Json;
using NUnit.Framework;
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
        [Test]
        public void GetUsers()
        {
            var endpoint = "https://reqres.in/api/users";
            var client = new RestClient(endpoint);
            var request = new RestRequest(endpoint);
            request.Method = Method.Get;

            var response = client.Execute(request);
            var responseBody = 
                JsonConvert.DeserializeObject<UsersResponse>(response.Content);
                
        }

    }
}
