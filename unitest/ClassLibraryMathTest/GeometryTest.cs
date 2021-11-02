using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryMath;
namespace ClassLibraryMathTest
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void RectangleArea_2and3_expected6()
        {
            var geometry = new Geometry();
            Assert.AreEqual(6, geometry.RectangleArea(2, 3));
        }
        [TestMethod]
        public void RectangleArea_negtive2and3_expectedArgumentExeption()
        {
            
            try
            {
                var geometry = new Geometry();
                geometry.RectangleArea(-2, 3);
            }
            catch (ArgumentException e)
            {
                Assert.IsTrue(true, e.Message);
                return;
            }

            Assert.Fail();
        }
        [TestMethod]
        public void RectangleArea_0and3_expectedArgumentExeption()
        {

            try
            {
                var geometry = new Geometry();
                geometry.RectangleArea(0, 3);
            }
            catch (ArgumentException e)
            {
                Assert.IsTrue(true, e.Message);
                return;
            }

            Assert.Fail();
        }
    }
}
