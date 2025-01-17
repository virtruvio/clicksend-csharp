/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Model;using IO.ClickSend.ClickSend.Api;

namespace IO.ClickSend.Test
{
    /// <summary>
    ///  Class for testing MmsCampaignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MmsCampaignApiTests
    {
        private MmsCampaignApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MmsCampaignApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MmsCampaignApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MmsCampaignApi
            //Assert.IsInstanceOfType(typeof(MmsCampaignApi), instance, "instance is a MmsCampaignApi");
        }

        
        /// <summary>
        /// Test MmsCampaignByMmsCampaignIdGet
        /// </summary>
        [Test]
        public void MmsCampaignByMmsCampaignIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? mmsCampaignId = null;
            //var response = instance.MmsCampaignByMmsCampaignIdGet(mmsCampaignId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsCampaignsByMmsCampaignIdPut
        /// </summary>
        [Test]
        public void MmsCampaignsByMmsCampaignIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? mmsCampaignId = null;
            //MmsCampaign campaign = null;
            //var response = instance.MmsCampaignsByMmsCampaignIdPut(mmsCampaignId, campaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsCampaignsCancelByMmsCampaignIdPut
        /// </summary>
        [Test]
        public void MmsCampaignsCancelByMmsCampaignIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? mmsCampaignId = null;
            //var response = instance.MmsCampaignsCancelByMmsCampaignIdPut(mmsCampaignId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsCampaignsGet
        /// </summary>
        [Test]
        public void MmsCampaignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.MmsCampaignsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsCampaignsPricePost
        /// </summary>
        [Test]
        public void MmsCampaignsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MmsCampaign campaign = null;
            //var response = instance.MmsCampaignsPricePost(campaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsCampaignsSendPost
        /// </summary>
        [Test]
        public void MmsCampaignsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MmsCampaign campaign = null;
            //var response = instance.MmsCampaignsSendPost(campaign);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
