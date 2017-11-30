using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        readonly RestClient _client = new RestClient("http://localhost/api/v1/");
        RestRequest _request = new RestRequest();
        IRestResponse _response;

        [TestMethod]
        public void TestMethod1()
        {
            _request = new RestRequest("calculator/20", Method.GET);
            IRestResponse<int> response = _client.Execute<int>(_request);
            Assert.AreEqual(response.Data, 32);
        }
    }
}
