using System.ComponentModel.DataAnnotations;

namespace _1811062844_Nguyencaoanhtruong_Tuan3.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}