﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dog_Go.Models
{
    public class Walker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        public string ImageUrl { get; set; }
        // Template for a new neighborhood instance:
        public Neighborhood Neighborhood { get; set; }
        public List<Walks> Walks { get; set; }
    }
}
