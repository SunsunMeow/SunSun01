using AutoMapper;
using SunSun.Data.Infrastructure;
using SunSun.Data.Repositories;
using SunSun.Model.Models;
using SunSun.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SunSun.Web.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService;
        public ActionResult  Index()
        {
            var  list = (List<Product>)productService.GetAll();
            return View(list);
        }
        public ActionResult Add()
        {

            return View();
        }
        
    }

}