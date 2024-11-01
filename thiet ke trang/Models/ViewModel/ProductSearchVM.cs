using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using PagedList.Mvc;
namespace thiet_ke_trang.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        public decimal? Minprice { get; set; }
        public decimal? Maxprice { get; set; }
        public string SortOrder { get; set; }
        public int PageNumber { get;set; }
        public int PageSize { get; set; } = 10;
        public PagedList.IPagedList<Product>Products { get; set; }
        //public List<Product> Products { get; set;}
    }
}