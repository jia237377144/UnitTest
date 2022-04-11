using System;
namespace Practice.Models
{
    public class Restaurant
    {
        public Restaurant(string name,Location location)
        {
            this.Location = location;
            this.Name = name;
        }
        public string Name { get; }
        public Location Location { get; }
    }
}
