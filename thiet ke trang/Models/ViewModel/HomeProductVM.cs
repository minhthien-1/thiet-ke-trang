using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
namespace thiet_ke_trang.Models.ViewModel
{
    public class HomeProductVM
    {
        public string SearchTerm { get; set; }
        public List<Product> FeaturesProducts { get; set;}
        public PagedList.IPagedList<Product> NewProducts { get; set; }
    }
}