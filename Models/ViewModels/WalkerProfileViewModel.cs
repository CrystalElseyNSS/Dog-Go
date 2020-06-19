using System;
using System.Collections.Generic;
using Dog_Go.Models;

namespace Dog_Go.Models.ViewModels
{
    public class WalkerProfileViewModel
    {
        public Walker Walker { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public List<Walks> Walks { get; set; }
    }
}