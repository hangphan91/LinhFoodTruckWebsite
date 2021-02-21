using System;
namespace Location.Definition.Entities
{
    public class Location
    {
        public long Id { get; set; }
        public string FullAddress { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime InsertTS { get; set; }
        public string LocationDescription { get; set; }
    }
}
