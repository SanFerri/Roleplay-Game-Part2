namespace Library
{
    public interface ICharacter
    {
        int AttackValue();
        int DefenseValue();
        int Health();
        void ReceiveAttack(int power);
        void Cure();
    }   
}