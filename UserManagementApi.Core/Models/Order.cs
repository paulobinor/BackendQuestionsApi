using System.ComponentModel.DataAnnotations;

namespace UserManagementApi.Core.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}