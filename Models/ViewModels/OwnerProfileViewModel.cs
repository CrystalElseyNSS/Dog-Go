using System;
using System.Collections.Generic;
using Dog_Go.Models;

namespace Dog_Go.Models.ViewModels
{
    public class OwnerProfileViewModel
    {
        public Owner Owner { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Neighborhood> Neighborhoods { get; set; }
    }
}