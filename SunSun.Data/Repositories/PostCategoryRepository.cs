using SunSun.Data.Infrastructure;
using SunSun.Model.Models;

namespace SunSun.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
       
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}