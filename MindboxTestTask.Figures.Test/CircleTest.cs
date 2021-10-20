using System;
using Xunit;

namespace MindboxTestTask.Figures.Test
{
    public class CircleTest
    {
        [Fact]
        public void ThrowExceptionIfRadiusNegative()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Circle(-1));
            
            Assert.Equal("Radius can't be negative. -1 was given", exception.Message);
        }
        
        [Fact]
        public void CalculateArea()
        {
            Assert.Equal(28.274333882308138D, new Circle(3).Area());
        }
    }
}