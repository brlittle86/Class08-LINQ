using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQLab
{
    class Feature
    {
        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }
    }
}
