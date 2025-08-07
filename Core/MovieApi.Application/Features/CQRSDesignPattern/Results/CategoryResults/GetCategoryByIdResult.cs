using System;
using System.Collections.Generic;

namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryByIdResult
    {
        public int CategoryId { get; set; }  // Primary key
        public string CategoryName { get; set; }

    }
}
