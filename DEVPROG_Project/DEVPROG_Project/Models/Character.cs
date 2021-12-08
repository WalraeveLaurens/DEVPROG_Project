using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace DEVPROG_Project.Models
{
    public class Character
    {
        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }

        [JsonProperty(propertyName: "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(propertyName: "lastName")]
        public string LastName { get; set; }

        [JsonProperty(propertyName: "fullName")]
        public string FullName { get; set; }

        [JsonProperty(propertyName: "title")]
        public string Title { get; set; }

        [JsonProperty(propertyName: "family")]
        public string Family { get; set; }

        [JsonProperty(propertyName: "image")]
        public string Image { get; set; }

        [JsonProperty(propertyName: "imageUrl")]
        public string ImageUrl { get; set; }


    }
}
