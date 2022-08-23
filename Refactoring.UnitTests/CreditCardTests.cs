namespace Refactoring.UnitTests
{
    public class CreditCardTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreditCardIsInvalid()
        {
            var card = new CreditCard("5541801923795240");

            Assert.IsFalse(card.IsValid());
        }

        [Test]
        public void CreditCardIsValid()
        {
            var card = new CreditCard("5541808923795240");

            Assert.IsTrue(card.IsValid());
        }
    }
}