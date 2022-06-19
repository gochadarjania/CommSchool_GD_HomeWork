﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_17.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string HomeNumber { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>();

    }
}
