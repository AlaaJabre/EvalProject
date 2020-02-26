using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    public class Building
    {
        private string _description;
        private List<string> _parts;

        public Building()
        {
            _description = "";
            _parts = new List<string>();
        }

        public Building AddKitchen()
        {
            _parts.Add("Kitchen");
            return this;
        }
        
        public Building AddBedroom(string bedroomName)
        {
            _parts.Add(bedroomName + " room");
            return this;
        }

        public Building AddBalcony()
        {
            _parts.Add("Balcony");
            return this;
        }

        public Building Build()
        {
            _description = String.Join(",", _parts);

            return this;
        }

        public string Describe()
        {
            return _description;
        }
    }
}
