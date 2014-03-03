using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWpfApp.Model
{
    class Grunt : Unit
    {
        public Grunt() : base("Zag, zag!") { }
        public Grunt(String defaultPhrase) : base(defaultPhrase) { }

        public override String UnitRace { get { return "Orc"; } }
    }
}
