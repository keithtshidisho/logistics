﻿using FasTnT.IntegrationTests.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;

namespace FasTnT.IntegrationTests.API.EpcisEndpoints.v1._2.ListSubscriptionIDs
{
    [TestClass]
    [TestCategory("IntegrationTests")]
    public class WhenListingSubscriptionIds : BaseMigratedIntegrationTest
    {
        public override void Act()
        {
            Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", "YWRtaW46UEBzc3cwcmQ=");
            Result = Client.PostAsync("/EpcisServices/1.2/Query", new StringContent(File.ReadAllText("Requests/ListSubscriptionIDs.xml"), Encoding.UTF8, "application/xml")).Result;
        }

        [Assert]
        public void ItShouldReturnHttp200OK() => Assert.AreEqual(HttpStatusCode.OK, Result.StatusCode);

        [Assert]
        public void ItShouldReturnANotNullContent()
        {
            var content = Result.Content.ReadAsStringAsync().Result;

            Assert.IsNotNull(content);
        }

        [Assert]
        public void ItShouldReturnAValidXmlContent()
        {
            var content = Result.Content.ReadAsStringAsync().Result;
            var xmlDocument = XDocument.Parse(content);

            Assert.IsNotNull(xmlDocument);
        }

        [Assert]
        public void ItShouldReturnAGetSubscriptionIDsResult()
        {
            var content = Result.Content.ReadAsStringAsync().Result;
            var xmlDocument = XDocument.Parse(content);
            var getSubscriptionResult = xmlDocument.Root.Element("EPCISBody").Element(XName.Get("GetSubscriptionIDsResult", "urn:epcglobal:epcis-query:xsd:1"));

            Assert.IsNotNull(getSubscriptionResult);
        }
    }
}