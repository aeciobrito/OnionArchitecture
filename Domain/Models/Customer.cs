using Domain.Models.Interfaces;

namespace Domain.Models
{
    public class Customer : IEntity
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

        public void Deactivate()
        {
            throw new NotImplementedException();
        }
        #endregion

        public string CustomerName { get; private set; } = string.Empty;
        public string PurchasesProduct { get; private set; } = string.Empty;
        public string PaymentType { get; private set; } = string.Empty;

       
    }
}
