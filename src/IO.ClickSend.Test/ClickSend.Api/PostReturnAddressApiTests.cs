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
    ///  Class for testing PostReturnAddressApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PostReturnAddressApiTests
    {
        private PostReturnAddressApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PostReturnAddressApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PostReturnAddressApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PostReturnAddressApi
            //Assert.IsInstanceOfType(typeof(PostReturnAddressApi), instance, "instance is a PostReturnAddressApi");
        }

        
        /// <summary>
        /// Test PostReturnAddressesByReturnAddressIdDelete
        /// </summary>
        [Test]
        public void PostReturnAddressesByReturnAddressIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? returnAddressId = null;
            //var response = instance.PostReturnAddressesByReturnAddressIdDelete(returnAddressId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostReturnAddressesByReturnAddressIdGet
        /// </summary>
        [Test]
        public void PostReturnAddressesByReturnAddressIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? returnAddressId = null;
            //var response = instance.PostReturnAddressesByReturnAddressIdGet(returnAddressId);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostReturnAddressesByReturnAddressIdPut
        /// </summary>
        [Test]
        public void PostReturnAddressesByReturnAddressIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? returnAddressId = null;
            //Address returnAddress = null;
            //var response = instance.PostReturnAddressesByReturnAddressIdPut(returnAddressId, returnAddress);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostReturnAddressesGet
        /// </summary>
        [Test]
        public void PostReturnAddressesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.PostReturnAddressesGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test PostReturnAddressesPost
        /// </summary>
        [Test]
        public void PostReturnAddressesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Address returnAddress = null;
            //var response = instance.PostReturnAddressesPost(returnAddress);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
