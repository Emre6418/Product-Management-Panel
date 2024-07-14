using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }

        [DisplayName("Kategori Adı")]
        public string Category_Name { get; set; }
        public virtual ICollection<SubCategory>? SubCategories { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
