using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebShop.Tests
{
    public class TestExamples
    {
        [Theory]
        [InlineData(2,10,1024)]
        [InlineData(3,3,27)]
        [InlineData(4,4,256)]
        public void TestMathPowShouldReturn1024WhenGiven2And10(int num, int exp, int result)
        {
            Console.WriteLine("Resharper is here");
            var experctedResult = Math.Pow(num, exp);
            Assert.Equal(experctedResult, result); 
        }
    }
}
 