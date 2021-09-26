namespace Library
{
    public interface IMagician
    {
        int AttackValue{get; }
        int DefenseValue{get; }
        int Health{get; }
        void ReceiveAttack(int power);
        void Cure();
        Staff Staff { get; set; }
        SpellsBook SpellsBook { get; set; }
        string Name {get; set; }
    }   
}