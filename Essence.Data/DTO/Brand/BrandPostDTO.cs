﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essence.Data.DTO
{
    public class BrandPostDTO
    {
        [StringLength(100)]
        public string Name { get; set; }
        public IFormFile? File { get; set; }

    }
}
