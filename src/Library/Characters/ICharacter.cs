namespace Library
{
    public interface ICharacter
    {
        int AttackValue{get; }
        int DefenseValue{get; }
        int Health{get; }
        void ReceiveAttack(int power);
        void Cure();
        string Name {get; set; }
    }   
}