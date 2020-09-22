using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public abstract class Instrument
    {
        protected string Name;

        public abstract void Play();    
    }
}
