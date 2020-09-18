using PrimaryLibrary;
using System;

namespace SecondaryLibrary
{
    public class Class2
    {
        public Class1 Class1 { get; set; }

        public string SomeKey1 { get; private set; }

        public Class2()
        {
            Class1 = new Class1();
            Class1.SomeFunction("somestring");
        }

        public void SomeFunction(string val)
        {
            SomeKey1 = val;
        }
    }
}
