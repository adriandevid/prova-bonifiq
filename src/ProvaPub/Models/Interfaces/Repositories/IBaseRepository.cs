namespace ProvaPub.Models.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        List<TEntity> getPaginationList(int page, int totalPage);
    }
}
