using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class Customer : Entity
    {
        public Customer(string customerName, string purchasesProduct, string paymentType)
        {
            CustomerName = customerName;
            PurchasesProduct = purchasesProduct;
            PaymentType = paymentType;
            CreatedDate = DateTime.Now;
            IsActive = true;
        }

        #region Entity
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
       
        public bool Validate()
        {
            throw new NotImplementedException();
        }
        #endregion

        public string CustomerName { get; private set; } = string.Empty;
        public string PurchasesProduct { get; private set; } = string.Empty;
        public string PaymentType { get; private set; } = string.Empty;

       
    }
}
