using CountVowels;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowelsTest
{
    [TestFixture]
    public class VowelCountTest
    {
        
        [Test]
        [TestCase("EVANS", 2)]
        [TestCase("ras", 1)]
        public void countVowels_WhenCalled_ShouldCountVowelsUsed( string name, int output) 
        {
            //TRIPLE A
            //ARRANGE
            VowelCount test = new();

            //ACT
            var result=test.countVowels( name);

            //ASSERT
            Assert.That(result, Is.EqualTo(output));

        }
    }
}
