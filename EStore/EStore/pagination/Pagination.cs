namespace EStore.pagination
{
    public class Pagination<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public bool HasPrevious { get; set; }
        public bool HasNext { get; set; }
        public Pagination(List<T> items, int count, int pageNumber, int pagesize)
        {
            TotalCount = count;
            PageSize = pagesize;
            CurrentPage = pageNumber;
            TotalPage = (int)Math.Ceiling(count / (double)PageSize);
            AddRange(items);

        }
        public static Pagination<T> GetPageList(IQueryable<T> ts, int pageNumber, int pageSize)
        {
            var count = ts.Count();
            var items = ts.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new Pagination<T>(items, count, pageNumber, pageSize);
        }

    }
}
