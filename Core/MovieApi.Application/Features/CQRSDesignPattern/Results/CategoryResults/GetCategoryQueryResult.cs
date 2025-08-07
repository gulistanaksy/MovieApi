using System;
using System.Collections.Generic;

namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }  // Primary key
        public string CategoryName { get; set; }

    }
}
