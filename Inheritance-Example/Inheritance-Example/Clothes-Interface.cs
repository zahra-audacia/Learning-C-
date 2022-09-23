using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    public class Clothes
    {
        private int Id { get; set; }
        public string category { get; set; }
        public int size { get; set; }
        public string gender { get; set; }
        public string brand { get; set; }
    }

    public class NikeShoes : Clothes
    {
        public string colour { get; set; }

    }

    public class Tops : Clothes
    {
        public int sleeveLength { get; set; }
    }




}
