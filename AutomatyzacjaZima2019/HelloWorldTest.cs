using System;
using Xunit;

namespace AutomatyzacjaZima2019
{
    public class HelloWorldTest
    {
        [Fact]
        public void CanSayHello()
        {
            var a = 1;
            var b = 2;
            var result = function(a, b);
            Assert.Equal(42, result);
        }

        private int function(int a, int b)
        {
            return 42;
        }
    }
}
