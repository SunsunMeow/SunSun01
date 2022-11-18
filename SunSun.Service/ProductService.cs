using SunSun.Data.Infrastructure;
using SunSun.Data.Repositories;
using SunSun.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunSun.Service
{   
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        IEnumerable<Product> GetAll();
        Product GetByID(int id);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        readonly IProductRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Product product)
        {
            _repository.Add(product);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll(new string[] { "ProductCategory" });
        }

        public Product GetByID(int id)
        {
            return _repository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _repository.Update(product);
        }
    }
}
