using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class RaceCarDriver
    {
        string name;
        int wins;

        public string Name { get => name; set => name = value; }
        public int Wins { get => wins; set => wins = value; }
    }
}
