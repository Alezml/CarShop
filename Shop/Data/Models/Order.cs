using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введите имя")]
        [StringLength(2)]
        [Required(ErrorMessage = "Длинна имени не менее 2 символов")]
        public string name { get; set; }
        [Display(Name = "Введите фамилию")]
        [StringLength(2)]
        [Required(ErrorMessage = "Длинна имени не менее 2 символов")]
        public string surname { get; set; }
        [Display(Name = "Введите адрес")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длинна адреса не менее 15 символов")]
        public string adress { get; set; }
        [Display(Name = "Введите имя")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "Длинна номера не менее 10 символов")]
        public string phone { get; set; }
        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(8)]
        [Required(ErrorMessage = "Длинна email не менее 8 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetail { get; set; }

    }
}
