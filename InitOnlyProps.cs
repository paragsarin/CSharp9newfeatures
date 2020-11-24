using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9newfeatures
{
    class InitOnlyProps
    {
        public string Name { get; init; }

        public string Address { get; set; }

        public InitOnlyProps()
        {
            Name = "anoynmous";
            Address = "none";
        }

        public InitOnlyProps(string newName, string newAddress)
        {
            Name = newName;
            Address = newAddress;
        }


        private void ChangeName(string newName, string newAddress)
        {
            //Not allowed
            //Name = newName;
            Address = newAddress;
        }

    }
}
