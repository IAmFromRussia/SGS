﻿﻿using Entities;
 using Newtonsoft.Json;

 namespace ParceData
{
    public class Valute : AuditableEntity
    {
        [JsonProperty("Id")]
        public string ValuteId { get; set; } 
        public string NumCode { get; set; } 
        public string CharCode { get; set; } 
        public int Nominal { get; set; } 
        public string Name { get; set; } 
        public double Value { get; set; } 
        public double Previous { get; set; } 
    }
}