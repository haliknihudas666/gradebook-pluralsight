using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //Arrange
            var book = new Book("Hudas Grades");
            book.AddGrade(90.5);
            book.AddGrade(93.6);
            book.AddGrade(89.6);
            

            //Act
            var result = book.GetStatistics();

            //Assert
            Assert.Equal(91.2,result.Average, 1);
            Assert.Equal(93.6,result.High, 1);
            Assert.Equal(89.6,result.Low, 1);
        }
    }
}
