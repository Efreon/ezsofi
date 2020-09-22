using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        int NumberOfStrings;

        public abstract void Sound();

        public override void Play()
        {
            Sound();
        }
    }
}
