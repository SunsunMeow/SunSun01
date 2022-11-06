using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using SunSun.Data.Infrastructure;
using SunSun.Model.Models;

namespace SunSun.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

       
    }
}