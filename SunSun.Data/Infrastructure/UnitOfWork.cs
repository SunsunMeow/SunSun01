using SunSun.Model.Models;

namespace SunSun.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly IDbFactory dbFactory;
        public SunSunShopDBContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public SunSunShopDBContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}