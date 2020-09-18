using SecondaryLibrary;
using Xunit;

namespace SecondaryTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void MethodSetsProperty()
        {
            var class1 = new Class2();
            class1.SomeFunction("something");
            Assert.Equal("something", class1.SomeKey1);
        }
    }
}
