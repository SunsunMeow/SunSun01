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
        public ProductRepository productRepository;
        public ActionResult  Index()
        {
            var  list = (List<Product>)productRepository.GetAll();
            return View(list);
        }
        public ActionResult Add(Product product)
        {
            
            return View(pro);
        }
        
    }

}