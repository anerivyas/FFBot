using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bot_Application1.DataModels
{
    public class Timeline
    {
        [JsonProperty(PropertyName = "Id")]
        public string ID { get; set; }

        [JsonProperty(PropertyName = "Firstname")]
        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "Comments")]
        public string Comments { get; set; }

    }
}