using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {
            Shape cirlce = new Shape(2);

            Assert.AreEqual(cirlce.GetSquare(), 12.56);
            Assert.IsTrue(cirlce.IsShapeRectangular());
        }
        [TestMethod]
        public void TestTriangle()
        {
            Shape triangle = new Shape(5, 5, 5);

            Assert.AreEqual(triangle.GetSquare(), 10.8253);
            Assert.IsTrue(triangle.IsShapeRectangular());
        }
        [TestMethod]
        public void TestSquare()
        {
            Shape square = new Shape(5, 5, 5, 5);
            Assert.AreEqual(square.GetSquare(), 25.0);
            Assert.IsTrue(square.IsShapeRectangular());
        }
    }
}
