﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLab
{
    public class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }

    public class Properties
    {
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Borough { get; set; }
        public string Neighborhood { get; set; }
        public string County { get; set; }
    }

    public class Feature
    {
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
    }

    public class RootObject
    {
        public string Type { get; set; }
        public List<Feature> Features { get; set; }
    }
}
