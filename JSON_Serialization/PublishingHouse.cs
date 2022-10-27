using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Serialization
{
    internal class PublishingHouse
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; }

        public PublishingHouse(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }   
    }
}
