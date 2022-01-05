/*
 * Unsplash API
 *
 * This document describes the resources that make up the official Unsplash JSON API. 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using OASPlash.Core.Client;
using OASPlash.Core.Api;
// uncomment below to import models
//using OASPlash.Core.Model;

namespace OASPlash.Core.Test.Api
{
    /// <summary>
    ///  Class for testing TopicsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TopicsApiTests : IDisposable
    {
        private TopicsApi instance;

        public TopicsApiTests()
        {
            instance = new TopicsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TopicsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TopicsApi
            //Assert.IsType<TopicsApi>(instance);
        }

        /// <summary>
        /// Test GetTopicPhotos
        /// </summary>
        [Fact]
        public void GetTopicPhotosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string idOrSlug = null;
            //int? page = null;
            //int? perPage = null;
            //Orientation? orientation = null;
            //OrderBy? orderBy = null;
            //var response = instance.GetTopicPhotos(idOrSlug, page, perPage, orientation, orderBy);
            //Assert.IsType<List<Photo>>(response);
        }

        /// <summary>
        /// Test ListTopics
        /// </summary>
        [Fact]
        public void ListTopicsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ids = null;
            //int? page = null;
            //int? perPage = null;
            //TopicsOrderBy? orderBy = null;
            //var response = instance.ListTopics(ids, page, perPage, orderBy);
            //Assert.IsType<List<Topic>>(response);
        }
    }
}
