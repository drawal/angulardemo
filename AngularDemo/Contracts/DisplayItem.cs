﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class DisplayItem
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public bool IsActive { get; set; }
        public string Balance { get; set; }
        public string Picture { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Registered { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string[] Tags { get; set; }
        public Friend[] Friends { get; set; }
        public string Greeting { get; set; }
        public string FavoriteFruit { get; set; }
    }

    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}