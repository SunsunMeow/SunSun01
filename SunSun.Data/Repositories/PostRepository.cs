using System;
using System.Collections;
using System.Collections.Generic;
using SunSun.Data.Infrastructure;
using SunSun.Model.Models;
using System.Linq;

namespace SunSun.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
        IEnumerable<Post> GetMultiPaging(string tag, int page, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;

            totalRow = query.Count();

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }

        public IEnumerable<Post> GetMultiPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }
    }
}