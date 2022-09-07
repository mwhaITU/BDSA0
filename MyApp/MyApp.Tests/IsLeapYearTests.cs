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
        Assert.True(result);
    }

    [Fact]
    public void Int_Divisible_By_One_Hundred()
    {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(1800);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Int_Divisible_By_Four_Hundred()
    {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(2000);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Year_Cap_Gives_Correct_Output() {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(1200);

        // Assert
        Assert.False(result);
    }
}