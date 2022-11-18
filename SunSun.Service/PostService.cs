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
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        Post GetByID(int id);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        readonly IPostRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        public PostService(IPostRepository repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
           _repository.Add(post);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public IEnumerable<Post> GetAll()
        {
            return _repository.GetAll(new string[] {"PostCategory"});
        }
        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _repository.Update(post);
        }

        public Post GetByID(int id)
        {
            return _repository.GetSingleById(id);
        }
    }
}
