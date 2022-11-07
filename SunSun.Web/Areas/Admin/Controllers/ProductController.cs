using AutoMapper;
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
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IDbFactory dbFactory, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _productRepository = productRepository;
            _dbFactory = dbFactory;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult  Index()
        {
            var products = _productRepository.GetAll();
            return View(products.ToList());
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Detail()
        {
            return View();
        }
        
    }
}