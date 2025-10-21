using Xunit;
using Labwork10;

namespace PasswordValidatorTests
{
    public class PasswordTests
    {
        [Theory]
        [InlineData("Password1", true)] 
        [InlineData("12345678", false)]
        [InlineData("abcdefg", false)] 
        [InlineData("Short1", false)]
        [InlineData("Valid123", true)] 
        [InlineData("NoDigitsOrLetters", false)] 
        [InlineData("Password!", false)] 
        [InlineData("1234567a", true)] 
        [InlineData("P@ssw0rd", true)] 
        public void ValidatePassword_ShouldReturnExpectedResult(string password, bool expectedResult)
        {
            bool result = PasswordValidator.ValidatePassword(password); //Вызов метода проверки пароля
            Assert.Equal(expectedResult, result); //Сравнение результата
        }
    }
}