using SiteManagementSystem.Repository.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Repository.Bills
{
    public class Bill:BaseEntity<int>
    {
        public int ApartmentId { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; } // "Electricity", "Water", "Gas", "Maintenance"
        public DateTime DueDate { get; set; }
        public string IsPaid { get; set; }

        public  Payment? Payment { get; set; }

        public Bill()
        {
        }

        public Bill(int ıd, int apartmentId, decimal amount, string type, DateTime dueDate, string ısPaid)
        {
            Id = ıd;
            ApartmentId = apartmentId;
            Amount = amount;
            Type = type;
            DueDate = dueDate;
            IsPaid = ısPaid;
        }
    }
}
