using System;

namespace PrimaryLibrary
{
    public class Class1
    {
        public string SomeKey { get; private set; }

        public void SomeFunction(string val)
        {
            SomeKey = val;
        }
    }
}
