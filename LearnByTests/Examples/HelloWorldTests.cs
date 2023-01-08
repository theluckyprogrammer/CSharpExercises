
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckExercise
{
    // https://exercism.org/tracks/csharp/exercises/hello-world
    
    public class HelloWorldTests
    {
        [Fact]
        public void Say_hi_()
        {
            Assert.Equal("Hello, World!", HelloWorld.Hello());
        }
    }
}
