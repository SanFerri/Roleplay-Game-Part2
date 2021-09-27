namespace Library
{
    /// <summary>
    /// IMagician es subtipo de ICharacter ya que posee los mismos metodos que ICharacter menos el Staff, y SpellsBook
    /// que es lo que tiene de diferente un Wizard de las demas clases.
    /// </summary>
    public interface IMagician : ICharacter
    {
        Staff Staff { get; set; }
        SpellsBook SpellsBook { get; set; }
    }   
}