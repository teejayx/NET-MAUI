using Service;

namespace MauitTest.Test;

public class UnitTest1
{
    [Fact]
    public void ShouldConvertWordsToText()
    {
        //Arrange
         string phoneWord = "1-555-NETMAUI";
        string expectedNumber = "1-555-6386284";
        //Act

        var actualNumber = PhoneWordTranslator.ToNumber(phoneWord);

        //Assert

        Assert.Equal(actualNumber, expectedNumber);
    }
}
