namespace Library
{
    /// <summary>
    /// Pueden ser defensivos o de ofensiva, este tipo solo lo tienen los wizards.
    /// </summary>
    public interface IMagicItem
    {
        int AttackValue{get; }
        int DefenseValue{get; }
    }    
}
