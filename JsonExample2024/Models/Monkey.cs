using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{
    public class Monkey
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public int Population { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\nLocation: {Location}\nDetails: {Details}\nImage: {Image}\nPopulation: {Population}\nLatitude: {Latitude}\nLongtitude: {Longitude}";
        }
    }
}
