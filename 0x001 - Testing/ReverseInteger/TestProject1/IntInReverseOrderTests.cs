using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseInteger;



namespace ReverseIntegerTests
{
    [TestFixture]
    public class IntInReverseOrderTests
    {
        [Test]
        public void reverseOrder_WhenCalled_ShouldReturnIntInReverse() 
        {
            //TRIPLE A STRUCTURE

            //ARRANGE => create an instance of the method we want to use
            IntInReverseOrder test = new();

            //ACT => act out the act of calling the method
            var result = test.reverseNumber("-499");

            //ASSERT => confirm if you're getting what you wanted/expected
            Assert.That(result, Is.EqualTo(-994));

        }
    }
}
