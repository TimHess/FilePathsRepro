using PrimaryLibrary;
using Xunit;

namespace PrimaryTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void MethodSetsProperty()
        {
            var class1 = new Class1();
            class1.SomeFunction("something");
            Assert.Equal("something", class1.SomeKey);
        }
    }
}
