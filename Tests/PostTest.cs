using System.Net;
using NUnit.Framework;
using RestSharp;

namespace Tests
{
    [TestFixture]
    class PostTest
    {
        [Test]
        public void PostReturnsCreated()
        {
            var client = new RestClient("http://localhost:8008");
            var request = new RestRequest("/", Method.POST);
            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }
    }
}
