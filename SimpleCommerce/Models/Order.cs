using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCommerce.Models
{
    public class Order
    {
        public Order()
        {
            CreateDate = DateTime.Now;
        }

        public int Id { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Sahibi")]
        public string Owner { get; set; }
        [Display(Name = "Sepet")]
        public int CartId { get; set; }
        [ForeignKey("CartId")]
        [Display(Name = "Sepet")]
        public Cart Cart { get; set; }
        [Display(Name = "Müşteri")]
        public int? CustomerId { get; set; }
        [Display(Name = "Müşteri")]
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [Display(Name = "Sipariş Durumu")]
        public OrderStatus OrderStatus { get; set; }
        [Display(Name = "Sipariş Notları")]
        [StringLength(4000)]
        public string ShippingNotes { get; set; }

        [StringLength(200)]
        [Display(Name ="Ödeme Yöntemi")]
        public string PaymentMethod { get; set; }
    }
}
