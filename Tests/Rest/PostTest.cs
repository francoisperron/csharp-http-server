using System.Net;
using NUnit.Framework;
using RestSharp;
using Tests.Helpers;

namespace Tests.Rest
{
    [TestFixture]
    class PostTest
    {
        [Test]
        public void PostReturnsCreated()
        {
            var client = new RestClient(Server.BaseUri);
            var request = new RestRequest("/", Method.POST);
            var response = client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }
    }
}
