namespace DataBase.Repositories
{
    public interface ICharactersRepository : IGenericRepository<Character>
    {
        public IEnumerable<Character> GetCharacterWithDetails();
        Task<Character> GetByIdWithDetail(int id);
    }
}