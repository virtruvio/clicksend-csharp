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
    ///  Class for testing MMSApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MMSApiTests
    {
        private MMSApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MMSApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MMSApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MMSApi
            //Assert.IsInstanceOfType(typeof(MMSApi), instance, "instance is a MMSApi");
        }

        
        /// <summary>
        /// Test MmsHistoryExportGet
        /// </summary>
        [Test]
        public void MmsHistoryExportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filename = null;
            //var response = instance.MmsHistoryExportGet(filename);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsHistoryGet
        /// </summary>
        [Test]
        public void MmsHistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string q = null;
            //int? dateFrom = null;
            //int? dateTo = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.MmsHistoryGet(q, dateFrom, dateTo, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsPricePost
        /// </summary>
        [Test]
        public void MmsPricePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MmsMessageCollection mmsMessages = null;
            //var response = instance.MmsPricePost(mmsMessages);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsReceiptsGet
        /// </summary>
        [Test]
        public void MmsReceiptsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.MmsReceiptsGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsReceiptsReadPut
        /// </summary>
        [Test]
        public void MmsReceiptsReadPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateBefore dateBefore = null;
            //var response = instance.MmsReceiptsReadPut(dateBefore);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test MmsSendPost
        /// </summary>
        [Test]
        public void MmsSendPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MmsMessageCollection mmsMessages = null;
            //var response = instance.MmsSendPost(mmsMessages);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
