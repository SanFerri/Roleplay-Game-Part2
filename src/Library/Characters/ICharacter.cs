namespace Library
{
    /// <summary>
    /// Agregamos la interfaz ICharacter que contiene todos los metodos de aquellas clases (Knight, Archer, Dwarf)
    /// cuyas diferencias son minimas.
    /// </summary>
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