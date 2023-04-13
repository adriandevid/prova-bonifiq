namespace ProvaPub.Models.Base
{
    public class PaginationItemList<TModel> where TModel : class
    {
        public List<TModel> Datas { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
        public int Page { get; set; }
    }
}
