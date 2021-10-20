using System;
using Xunit;

namespace Tests_Demo.Tests
{
    /// <summary>
    /// Ja skaitlis dalās ar 3 tad atgriez "Fizz"
    /// Ja skaitlis dalās ar 5 tad atgriez "Buzz"
    /// Ja skaitlis dalās ar 3 un 5 tad atgriez "FizzBuzz"
    /// Ja skaitlis nedalās ne ar 3 un ne ar 5 tad atgriez skaitli
    /// </summary>

    public class FizzBuzzTests
    {
        // Function_When_Then

        [Fact]
        public void GetNumber_WhenNumberDoesNotDivideBy3Or5_ThenReturnsNumber()
        {
            // Arrange
            var fizzClass = new FizzBuzz();

            // Act
            var fizzText = fizzClass.GetNumber(1);

            //Assert
            Assert.Equal("1", fizzText);

        }
    }
}
