using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeAPI
{
    class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
        public string ability { get; set; }
    }
    class Abilities
    {
        public List<Abilities> abilities { get; set; }
    }
}
