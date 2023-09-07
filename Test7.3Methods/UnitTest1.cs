
using _7._3Uzduotis_Methods_UnitTesting;

namespace Test7._3Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInitials()
        {
            string firstName = "Laura";
            string lastName = "Lauraite";
            string expected = "L.L.";

            string actual = Program.GetInitials(firstName, lastName);
            Assert.AreEqual(expected, actual);

        }
    }
}