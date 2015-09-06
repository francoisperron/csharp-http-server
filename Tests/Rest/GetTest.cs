using System.Net;
using NUnit.Framework;
using RestSharp;
using Tests.Helpers;

namespace Tests.Rest
{
    [TestFixture]
    class GetTest
    {
        [Test]
        public void GetReturnsOk()
        {
            var client = new RestClient(Server.BaseUri);
            var request = new RestRequest("/", Method.GET);
            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
