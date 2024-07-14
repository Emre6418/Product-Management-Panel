using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }

        [DisplayName("Alt Kategori Adı")]
        public string SubCategory_Name { get; set; } = string.Empty;

        [DisplayName("Kategori Adı")]
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Product>? Products { get; set; }


    }
}
