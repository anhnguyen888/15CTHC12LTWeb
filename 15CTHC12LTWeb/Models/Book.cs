
using System.ComponentModel.DataAnnotations;

namespace _15CTHC12LTWeb.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Tiêu đề sách không được trống!")]
        [StringLength(30, ErrorMessage = "Nhập quá ký tự cho phép")]
        public string Title { get; set; }

        public string Author { get; set; }

        public string Cover { get; set; }
    }
}