﻿using SimApi.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimApi.Schema.ProductRR
{
    public class ProductRequest : BaseRequest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
    }
}
