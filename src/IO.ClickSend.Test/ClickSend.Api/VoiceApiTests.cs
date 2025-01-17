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
    ///  Class for testing VoiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VoiceApiTests
    {
        private VoiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VoiceApi
            //Assert.IsInstanceOfType(typeof(VoiceApi), instance, "instance is a VoiceApi");
        }

        
        /// <summary>
        /// Test VoiceCancelAllPut
        /// </summary>
        [Test]
        public void VoiceCancelAllPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.VoiceCancelAllPut();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceCancelByMessageIdPut
        /// </summary>
        [Test]
        public void VoiceCancelByMessageIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string messageId = null;
            //var response = instance.VoiceCancelByMessageIdPut(messageId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceHistoryExportGet
        /// </summary>
        [Test]
        public void VoiceHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.VoiceHistoryExportGet(filename);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceHistoryGet
        /// </summary>
        [Test]
        public void VoiceHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.VoiceHistoryGet(dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceLangGet
        /// </summary>
        [Test]
        public void VoiceLangGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.VoiceLangGet();
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoicePricePost
        /// </summary>
        [Test]
        public void VoicePricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VoiceMessageCollection voiceMessages = null;
            //var response = instance.VoicePricePost(voiceMessages);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceReceiptsGet
        /// </summary>
        [Test]
        public void VoiceReceiptsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.VoiceReceiptsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceReceiptsPost
        /// </summary>
        [Test]
        public void VoiceReceiptsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Url url = null;
            //var response = instance.VoiceReceiptsPost(url);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceReceiptsReadPut
        /// </summary>
        [Test]
        public void VoiceReceiptsReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateBefore dateBefore = null;
            //var response = instance.VoiceReceiptsReadPut(dateBefore);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test VoiceSendPost
        /// </summary>
        [Test]
        public void VoiceSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VoiceMessageCollection voiceMessages = null;
            //var response = instance.VoiceSendPost(voiceMessages);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
