using NUnit.Framework;

namespace LessonOne.Tests
{
    public class SofaTests
    {
        //AAA
        [Test]
        public void NewColor_Applied()
        {
            //arrange
            var newColor = Color.Blue;
            var _sut = new Sofa
            {
                IsNew = true,
                Weight = 30.3m,
                SerialNumber = 235425,
                Color = Color.Black
            };

            //act
            _sut.Paint(newColor);

            //assert
            Assert.AreEqual(newColor, _sut.Color);
        }
    }
}