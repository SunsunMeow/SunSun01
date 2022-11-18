using Microsoft.VisualStudio.TestTools.UnitTesting;
using SunSun.Data.Infrastructure;
using SunSun.Data.Repositories;
using SunSun.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunSun.UnitTest.RepositoryTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        IDbFactory dbFactory;
        IProductRepository repository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            repository = new ProductRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public  void ProductRepository_Add()
        {
            Product product = new Product();
            product.Name = "Test Product";
            product.Alias = "Test Product";

            var result = repository.Add(product);
            unitOfWork.Commit();
        }
    }
}
