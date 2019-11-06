using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class pokemon
    {
        public string height { get; set; }
        public string name { get; set; }
        public string weight { get; set; }
        public List<form> forms {get;set;}

    public class form
    {
        
    }

        public override string ToString()
        {
            return $"{name} is {height} m tall and weighs {weight} kg.";
        }
    }
}
