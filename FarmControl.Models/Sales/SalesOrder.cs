using FarmControl.Models.Customers;
using FarmControl.Models.HR;
using FarmControl.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SalesOrder
    {
        public SalesOrder()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int SalesOrderID { get; set; }
        [Required]
        public DateTime CustomerOrderDate { get; set; }
        [Required]
        public DateTime OrderCreatedDate { get; set; }
        [Required]
        public DateTime DueDeliverydate { get; set; }
        [Required]
        public DateTime ShippingDate { get; set; }
        [EnumDataType(typeof(SalesOrderStatus))]
        public SalesOrderStatus OrderStatus { get; set; }
        [MaxLength(20)]
        public string SalesOrderNumber { get; set; }
        [MaxLength(20)]
        public string CustomerOrderRef { get; set; }
        //AccountNumber and CustomerDetails
        [EnumDataType(typeof(Customer))]
        public Customer Customer { get; set; }
        [EnumDataType(typeof(CustomerShippingAddress))]
        public CustomerShippingAddress CustomerShippingAddress { get; set; }
        [EnumDataType(typeof(CustomerShippingAddress))]
        public CustomerShippingAddress CustomerBillingAddress { get; set; }
        public SalesTerritory SalesTerritory { get; set; }
        [EnumDataType(typeof(Employee))]
        public Employee SalesPerson { get; set; }
        [EnumDataType(typeof(Product))]
        public Product  Product { get; set; }
        public int OrderQuantity { get; set; }
        [EnumDataType(typeof(SpecialOffer))]
        public SpecialOffer SpecialOffer { get; set; }
        //TODO: Add all cost Items
        [DataType(DataType.Currency)]
        public double UnitPrice { get; set; }
        [DataType(DataType.Currency)]
        public double TotalWithoutDiscountOverheads { get; set; }//Total without applying speciall offfer and adding taxes
        [DataType(DataType.Currency)]
        public double DiscountAmount { get; set; }//Add service to calculate the price
        [EnumDataType(typeof(SalesTaxRate))]
        public IEnumerable<SalesTaxRate> AppliedSalexTax { get; set; }
        [DataType(DataType.Currency)]
        public double TotalTaxAmount { get; set; }
        [DataType(DataType.Currency)]
        public double ShippingCost { get; set; }

        [DataType(DataType.Currency)]
        public double TotalPaymentDue { get; set; }

        public DateTime TotalPaymentDueDate { get; set; }
        public string Comments { get; set; }
        [EnumDataType(typeof(OrderPaymentStatus))]
        public OrderPaymentStatus OrderPaymentStatus { get; set; }

        public DateTime ModfiedDate { get; }


    }
    public enum OrderPaymentStatus
    {
        Pending,Partial,Paid
    }
}
