using System;
using System.Collections.Generic;
using Dog_Go.Models;

namespace DogGo.Models.ViewModels
{
    public class ProfileViewModel
    {
        public Owner Owner { get; set; }
        public List<Walker> Walkers { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}