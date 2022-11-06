using SunSun.Data.Infrastructure;
using SunSun.Data.Repositories;
using SunSun.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunSun.Web.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public IDbFactory _dbFactory;
        public IUnitOfWork _unitOfWork;
        public ProductController(IProductRepository productRepository, IDbFactory dbFactory, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _dbFactory = dbFactory;
            _unitOfWork = unitOfWork;
        }

        public ActionResult  Index()
        {
            var products = _productRepository.GetAll();
            return View(products.ToList());
        }
        
    }
}