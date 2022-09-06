namespace MyApp.Tests;

public class IsLeapYearTests
{
    [Fact]
    public void Int_Is_Leap_Year_Gives_Correct_Output()
    {
        // Arrange
        var leapYear = new IsLeapYear();

        // Act
        var result = leapYear.IntIsLeapYear(2024);

        // Assert
        Assert.True(result);

        // Act
        result = leapYear.IntIsLeapYear(1999);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void User_Input_Is_Leap_Year() 
    {
        // Arrange

        // Act

        // Assert
    }
}