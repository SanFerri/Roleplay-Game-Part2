namespace Library
{
    public interface IMagician
    {
        int AttackValue();
        int DefenseValue();
        int Health();
        void ReceiveAttack(int power);
        void Cure();
        IMagicItem Staff { get; set; }
        IMagicItem SpellsBook { get; set; }
    }   
}