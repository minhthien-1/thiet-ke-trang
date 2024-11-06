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

        // Các thuộc tính hỗ trợ phân trang
        public int PageNumber { get; set; } //trang hiện tại
        public int PageSize { get; set; } = 10; //Số sản phẩm mỗi trang
        public List<Product> FeatureProducts { get; set;}
        //danh sách sản phẩm mới đã phân trang 
        public PagedList.IPagedList<Product> NewProducts { get; set; }
        //danh sách sản phẩm nổi bật
        public List<Product> FeaturesProducts { get; internal set; }
    }
}