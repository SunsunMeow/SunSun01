using AutoMapper;
using SunSun.Model.Models;
using SunSun.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SunSun.Web.Mappings
{
    public class AutoMapperConfiguration: Profile
    {
        public AutoMapperConfiguration(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Product, ProductViewModel>();
            mapper.CreateMap<ProductViewModel, Product>();
        }
    }
}