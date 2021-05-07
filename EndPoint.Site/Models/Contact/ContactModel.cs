using System.ComponentModel.DataAnnotations;

namespace EndPoint.Site.Models.Contact
{
    public class ContactModel
    {
        [Required(ErrorMessage = "The field Name is required.")]
        //[Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        //[Display(Name = "نام خانوادگی ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The field Email is required.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "The e-mail address entered is invalid.")]
        public string Email { get; set; }

        
        //[MinLength(8, ErrorMessage = "نام کاربری حداقل باید هشت کاراکتر باشد")]
        //[Display(Name = "نام کاربری")]
        //public string Username { get; set; }

        //[Required(ErrorMessage = "لطفا رمز  را وارد کنید")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "رمز باید حداقل 8 رقم، و دارای حداقل یک حرف، یک عدد و یک کاراکتر ویژه باشد")]
        //[DataType(DataType.Password)]
        //[Display(Name = "رمز عبور")]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "لطفا تکرار رمز را وارد کنید")]
        //[RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&])[A-Za-z\d$@$!%*#?&]{8,}$", ErrorMessage = "تکرار رمز جدید باید حداقل 8 رقم، و دارای حداقل یک حرف، یک عدد و یک کاراکتر ویژه باشد")]
        //[DataType(DataType.Password)]
        //[Display(Name = "تکرار رمز عبور ")]
        //[Compare("Password", ErrorMessage = "رمز  و تکرار آن یکسان نیستند")]
        //public string RepeatePassword { get; set; }
        public long Id { get; set; }
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
