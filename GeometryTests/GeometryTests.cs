using GeometryLibrary;

namespace GeometryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 1e-10);
        }

        [TestMethod]
        public void TestTriangleIsRightAngled()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Radius must be positive.")]
        public void CircleConstructor_ShouldThrowException_ForNonPositiveRadius()
        {
            var circle = new Circle(-5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Sides must be positive.")]
        public void TriangleConstructorShouldThrowExceptionForNonPositiveSides()
        {
            var triangle = new Triangle(-1, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The sum of any two sides must be greater than the third side.")]
        public void TriangleConstructorShouldThrowExceptionForInvalidTriangle()
        {
            var triangle = new Triangle(1, 2, 3); // Invalid triangle
        }

        [TestMethod]
        public void TriangleConstructorShouldThrowExceptionForInvalidTriangleCheckErrorMessage()
        {
            try
            {
                // Act
                var triangle = new Triangle(1, 2, 3); // Invalid triangle

                // If no exception is thrown, the test fails
                Assert.Fail("Expected an ArgumentException to be thrown.");
            }
            catch (ArgumentException ex)
            {
                // Assert that the exception message is correct
                Assert.AreEqual("The sum of any two sides must be greater than the third side.", ex.Message);
            }
        }
    }
}