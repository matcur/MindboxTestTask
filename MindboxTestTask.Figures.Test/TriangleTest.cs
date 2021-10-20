using System;
using Xunit;

namespace MindboxTestTask.Figures.Test
{
    public class TriangleTest
    {
        [Fact]
        public void ThrowExceptionIfFirstSideIsNegative()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(-2, 2, 3));
            
            Assert.Equal("Side can't be negative. -2 was given", exception.Message);
        }
        
        [Fact]
        public void ThrowExceptionIfSecondSideIsNegative()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(2, -2, 3));
            
            Assert.Equal("Side can't be negative. -2 was given", exception.Message);
        }
        
        [Fact]
        public void ThrowExceptionIfThirdSideIsNegative()
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(2, 2, -3));
            
            Assert.Equal("Side can't be negative. -3 was given", exception.Message);
        }
        
        [Fact]
        public void CalculateArea()
        {
            var area = new Triangle(2, 2, 3).Area();
            
            Assert.Equal(1.984313483298443, area);
        }
        
        [Fact]
        public void IsRight()
        {
            Assert.True(new Triangle(3, 4, 5).IsRight());
        }
        
        [Fact]
        public void IsNotRight()
        {
            Assert.False(new Triangle(3, 3, 5).IsRight());
        }
    }
}