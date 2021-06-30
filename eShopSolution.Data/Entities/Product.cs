using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
   public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }
        public List<ProductInCategory> ProductInCategories { set; get; }
        public List<OrderDetail> OrderDetails { set; get; }
        public List<Cart> Carts { set; get; }
        public List<ProductTranslation> ProductTranslations { set; get; }

    }
}
