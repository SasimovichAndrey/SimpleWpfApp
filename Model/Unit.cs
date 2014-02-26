using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWpfApp.Model
{
    public abstract class Unit
    {
        public abstract String UnitRace{get;} 

        protected Unit(String defaultPhrase)
        {
            this.DefaultPhrase = defaultPhrase;
        }

        public String DefaultPhrase {get; set;}
    }
}
