﻿using AKSoftware.WebApi.Client;
using PlannerAppShared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannerAppShared.Services
{
    public class PlanService
    {
        private readonly string _baseUrl;

        ServiceClient client = new ServiceClient();

        public PlanService(string url)
        {
            _baseUrl = url;
        }

        public string AccessToken
        {
            get => client.AccessToken;
            set
            {
                client.AccessToken = value;
            }
        }

        /// <summary>
        /// Retrieve all the plans from the API with pagination
        /// </summary>
        /// <param name="page">Number of the page</param>
        /// <returns></returns>
        public async Task<PlansCollectionPagingResponse> GetAllPlansByPageAsync(int page)
        {
            var response = await client.GetProtectedAsync<PlansCollectionPagingResponse>($"{_baseUrl}/api/plans?page={page}");
            return response.Result;
        }

        /// <summary>
        /// Retrieve all the plans from the API with pagination
        /// </summary>
        /// <param name="page">Number of the page</param>
        /// <returns></returns>
        public async Task<PlansCollectionPagingResponse> SearchPlansByPageAsync(string query,int page=1)
        {
            var response = await client.GetProtectedAsync<PlansCollectionPagingResponse>($"{_baseUrl}/api/plans/search?query={query}&page={page}");
            return response.Result;
        }

        public async Task<PlanSingleResponse> PostPlanAsync(PlanRequest mode)
        {
            var response = await client.SendFormProtectedAsync<PlanRequest>()
        }
    }
}
