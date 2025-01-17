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
    ///  Class for testing NumberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by ClickSend Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NumberApiTests
    {
        private NumberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NumberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NumberApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NumberApi
            //Assert.IsInstanceOfType(typeof(NumberApi), instance, "instance is a NumberApi");
        }

        
        /// <summary>
        /// Test NumbersBuyByDedicatedNumberPost
        /// </summary>
        [Test]
        public void NumbersBuyByDedicatedNumberPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dedicatedNumber = null;
            //var response = instance.NumbersBuyByDedicatedNumberPost(dedicatedNumber);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test NumbersGet
        /// </summary>
        [Test]
        public void NumbersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.NumbersGet(page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test NumbersSearchByCountryGet
        /// </summary>
        [Test]
        public void NumbersSearchByCountryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string search = null;
            //int? searchType = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.NumbersSearchByCountryGet(country, search, searchType, page, limit);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
    }

}
