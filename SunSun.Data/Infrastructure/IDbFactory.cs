using SunSun.Model.Models;
using System;

namespace SunSun.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SunSunShopDBContext Init();
    }
}