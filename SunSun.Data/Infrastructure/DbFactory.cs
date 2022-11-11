using SunSun.Model.Models;

namespace SunSun.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        public SunSunShopDBContext dbContext;

        public SunSunShopDBContext Init()
        {
            return dbContext ?? (dbContext = new SunSunShopDBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}