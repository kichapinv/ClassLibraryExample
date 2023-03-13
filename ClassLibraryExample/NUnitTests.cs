using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GeometryTasks
{
    [TestFixture]
    internal class NUnitTests
    {
        [Test]
        public void GeometryTest()
        {
            Vector vector = new Vector();
            vector.X = 0;
            vector.Y = 0;
            
            Segment segment = new Segment();
            segment.Begin = new Vector();
            segment.End = new Vector();

            segment.Begin.X = 0;
            segment.Begin.Y = 0;
            segment.End.X = 2;
            segment.End.Y = 2;

            bool result = vector.Belongs(segment);
            Assert.AreEqual(true, result);
        }
    }
}
