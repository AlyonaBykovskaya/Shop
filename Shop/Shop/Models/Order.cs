using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Order
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        [StringLength(50)]
        public  string UserName { get; set; }

        [Required]
        [Display(Name = "Адрес электронной почты")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Неверный формат электронной почты")]
        public string Email { get; set; }

        [Required]
        [StringLength(800)]
        [Display(Name = "Название книги")]
        [DataType(DataType.MultilineText)]
        public string MessageText { get; set; } 
    
 
    }

}