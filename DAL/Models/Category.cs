﻿using System;
using System.Collections.Generic;
using DAL.Base;

namespace DAL.Models
{
	public class Category : BaseEntity
	{
        public string Name { get; set; }
        public List<Product> Products { get; set; }


    }
}

