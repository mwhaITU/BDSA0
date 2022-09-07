namespace MyApp.Tests;

public class IsLeapYearTests
{
    [Fact]
    public void Int_Divisible_By_Four()
    {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(2024);

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Int_Divisible_By_One_Hundred()
    {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(1800);

        // Assert
        result.Should().Be(false);
    }

    [Fact]
    public void Int_Divisible_By_Four_Hundred()
    {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(2000);

        // Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Year_Cap_Gives_Correct_Output() {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(1200);

        // Assert
        result.Should().Be(false);
    }
}