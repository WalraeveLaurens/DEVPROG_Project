using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace DEVPROG_Project.Models
{
    public class CharacaterCard
    {
        [JsonProperty(propertyName: "name")]
        public string Name { get; set; }
        [JsonProperty(propertyName: "desc")]
        public string Description { get; set; }
    }
}
