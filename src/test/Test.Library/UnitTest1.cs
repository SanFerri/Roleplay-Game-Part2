using NUnit.Framework;
using Library;

namespace Test.Library;


{
    public class Tests
    {
        public SpellsBook book = new SpellsBook();
        public book.Spells = new Spell[]{ new Spell() };

        public Wizard gandalf = new Wizard("Gandalf");
        public gandalf.Staff = new Staff();
        public gandalf.SpellsBook = book;

        public Dwarf gimli = new Dwarf("Gimli");
        public gimli.Axe = new Axe();
        public gimli.Helmet = new Helmet();

        [Test]
        public void ReceiveAttackTest()
        {
            int expected = gandalf.health - gimli.Axe.attack;
            gandlf.ReceiveAttack(gimli.AttackValue());
            int actual = gandalf.health;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CureTest()
        {
            Assert.Pass();
        }

    }
}