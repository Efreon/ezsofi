using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Counter
    {
        public int initialNumber;
        public Counter()
        {
            this.initialNumber = 0;
        }

        // we can Add(number) to this counter another whole number
        public int Add(int num)
        {
            return this.initialNumber += num;
        }
        // or we can Add() without parameters just increasing the counter's value by one
        public int Add()
        {
            return this.initialNumber += 1;
        }
        // and we can Get() the current value as string
        public string Get()
        {
            return initialNumber.ToString();
        }
        // also we can Reset() the value to the initial value
        public int Reset()
        {
            return this.initialNumber =0;
        }
    }
    
}
