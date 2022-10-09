namespace DataBase.Repositories
{
    public interface ICharactersRepository : IGenericRepository<Character>
    {
        public IEnumerable<Character> GetCharacterWithDetails();
    }
}