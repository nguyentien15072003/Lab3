using System.ComponentModel.DataAnnotations;

namespace Lab_1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required(ErrorMessage ="Họ và tên bắt buộc phải nhập")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail+\.com", ErrorMessage = "Bạn phải nhập gmail có chữ hoa, chữ thường, số, và đuôi gmail.com")]
        public string? Email { get; set; }

        //giới hạn tối đa độ dài chuỗi là 100, tối thiểu 8 ký tự

        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$", ErrorMessage ="Mật khẩu phải có 8 ký tự, có chữ và ký tự đặc biệt")]
        [StringLength(100, MinimumLength = 8)]
        [Required(ErrorMessage ="Bạn phải nhập mật khẩu")]
        public string? Password { get; set; }

        [Required(ErrorMessage ="bạn phải chọn khoa")]
        public Branch? Branch { get; set; }

        [Required(ErrorMessage ="Bạn phải chọn giới tính")]
        public Gender? Gender { get; set; }
        public bool IsRegular { get; set; }//hệ: true: chính qui, false: tại chức
        //ràng buộc người dùng chỉ đc chọn trong khoảng 1/1/1963 đến 12/31/2005
        [Range(typeof(DateTime), "1/1/1963", "12/31/2023", ErrorMessage = "Bạn chỉ đc chọn ngày sinh từ 1/1/11963 đến 31/12/2005")]
        [DataType(DataType.Date)]//ràng buộc kiểu datetime
        [Required(ErrorMessage ="Bạn phải nhập ngày sinh")]
        public DateTime? DateOfBirth { get; set; }

        //ko ràng buộc kiểu, có thể nhập nhiều dòng
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Bạn phải nhập địa chỉ")]
        public string? Address { get; set; }

        [Range(typeof(double), "0.0", "10.0", ErrorMessage ="Điểm từ 0.0 đến 10.0")]
        [Required(ErrorMessage ="Bạn phải nhập điểm")]
        public double? Marks { get; set; }
    }
}
