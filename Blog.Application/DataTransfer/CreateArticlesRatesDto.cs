using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Application.DataTransfer
{
    public class CreateArticlesRatesDto
    {
        public int UserId { get; set; }
        public int ArticleId { get; set; }
        public int RateId { get; set; }
    }
}
