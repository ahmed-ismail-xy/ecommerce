using System.ComponentModel.DataAnnotations;

namespace ecommerce.Domain.Entities
{
    public class ProductImg
    {
        [Key]
        public Guid ProductImgID { get; set; }
        public string ImgURL { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
