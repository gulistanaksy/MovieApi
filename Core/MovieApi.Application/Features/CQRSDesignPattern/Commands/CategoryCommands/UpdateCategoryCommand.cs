using System;
using System.Collections.Generic;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands
{
    public class UpdateCategoryCommmand
    {
        public int CategoryId { get; set; }  // Primary key
        public string CategoryName { get; set; }

    }
}
