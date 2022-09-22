﻿using COSTS_API.Models.Categories;
using COSTS_API.Models.Services;

namespace COSTS_API.Models.Projects
{
    public class Project
    {
        public int Id { get; set; }
        public decimal Budget { get; set; }
        public decimal Cost { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // Lista não será mapeada, pois no BD o Project não tem relação com Service, mas sim ao contrário
        public virtual IEnumerable<Service> MyProperty { get; set; } = new List<Service>();
    }
}
