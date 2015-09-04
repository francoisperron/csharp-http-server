using System.Net;
using NUnit.Framework;
using RestSharp;

namespace Tests
{
    [TestFixture]
    class GetTest
    {
        [Test]
        public void GetReturnsOk()
        {
            var client = new RestClient("localhost:8080");
            var request = new RestRequest("/", Method.GET);
            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
