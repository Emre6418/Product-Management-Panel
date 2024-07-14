

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Product_Name { get; set; } = string.Empty;

        [DisplayName("Ürün Açıklaması")]
        public string Product_Description { get; set; } = string.Empty;

        [DisplayName("Ürün Resmi")]
        public string Product_Image { get; set; } = string.Empty;

        [DisplayName("Ürün Fiyatı")]
        public decimal Product_Price { get; set; }

        [DisplayName("Kategori Adı")]
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category? Category { get; set; }

        [DisplayName("Alt Kategori Adı")]
        [ForeignKey("SubCategories")] //categories
        public int SubCategory_Id { get; set; }
        //public string SubCategory_Name { get; set; }
        public virtual SubCategory? SubCategory { get; set; }

        [DisplayName("Ürün Özellikleri")]
        public string Product_Feature { get; set; } = string.Empty;


    }
}
