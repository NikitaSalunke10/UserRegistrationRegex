using UserRegistrationRegex;
namespace RegexUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Patterns pattern = new Patterns();
        [TestMethod]
        public void ValidateFirstName()// this method is used to validate First Name
        {
            pattern.validateFName("Nikita");
            Assert.AreEqual(true, pattern.FNameCheck);
        }
        [TestMethod]
        public void ValidateLastName()// this method is used to validate Last Name
        {
            pattern.validateLName("Salunke");
            Assert.AreEqual(true, pattern.LNameCheck);
        }
        [TestMethod]
        public void ValidateMobileNo()// this method is used to validate Mobile no
        {
            pattern.validateMobile("91 9898989898");
            Assert.AreEqual(true, pattern.MobileCheck);
        }
        [TestMethod]
        public void ValidateEmailId()// this method is used to validate Email id
        {
            pattern.validateEmail("abc@ab.com");
            Assert.AreEqual(true, pattern.EmailCheck);
        }
        [TestMethod]
        public void ValidatePassword()// this method is used to validate Password
        {
            pattern.validatePassword("Abcdef@12");
            Assert.AreEqual(true, pattern.PasswordCheck);
        }
    }
}