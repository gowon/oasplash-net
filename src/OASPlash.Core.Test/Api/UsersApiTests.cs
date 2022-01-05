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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UsersApi
            //Assert.IsType<UsersApi>(instance);
        }

        /// <summary>
        /// Test GetUser
        /// </summary>
        [Fact]
        public void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetUser(username);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test GetUserCollections
        /// </summary>
        [Fact]
        public void GetUserCollectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? perPage = null;
            //var response = instance.GetUserCollections(username, page, perPage);
            //Assert.IsType<List<Collection>>(response);
        }

        /// <summary>
        /// Test GetUserLikedPhotos
        /// </summary>
        [Fact]
        public void GetUserLikedPhotosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? perPage = null;
            //OrderBy? orderBy = null;
            //Orientation? orientation = null;
            //var response = instance.GetUserLikedPhotos(username, page, perPage, orderBy, orientation);
            //Assert.IsType<List<Photo>>(response);
        }

        /// <summary>
        /// Test GetUserPhotos
        /// </summary>
        [Fact]
        public void GetUserPhotosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? perPage = null;
            //OrderBy? orderBy = null;
            //bool? stats = null;
            //StatResolution? resolution = null;
            //int? quantity = null;
            //Orientation? orientation = null;
            //var response = instance.GetUserPhotos(username, page, perPage, orderBy, stats, resolution, quantity, orientation);
            //Assert.IsType<List<Photo>>(response);
        }

        /// <summary>
        /// Test GetUserPortfolioLink
        /// </summary>
        [Fact]
        public void GetUserPortfolioLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.GetUserPortfolioLink(username);
            //Assert.IsType<PortfolioLink>(response);
        }

        /// <summary>
        /// Test GetUserStatistics
        /// </summary>
        [Fact]
        public void GetUserStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //StatResolution? resolution = null;
            //int? quantity = null;
            //var response = instance.GetUserStatistics(username, resolution, quantity);
            //Assert.IsType<UserStatistics>(response);
        }
    }
}
