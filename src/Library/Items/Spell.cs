namespace Library
{
    public class Spell : IDefensiveItem : IOffensiveItem : IMagicItem
    {
        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }
    }
}