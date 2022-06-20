using System;
using DAL.Base;

namespace DAL.Models
{
	public class Product : BaseEntity
	{
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Count { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

