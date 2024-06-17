using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Repository.Apartments
{
    public class Apartment:BaseEntity<int>
    {
        public string Block { get; set; }
        public string Status { get; set; } // "Occupied" or "Vacant"
        public string Type { get; set; } // "2+1", "3+1", etc.
        public int Floor { get; set; }
        public int ApartmentNumber { get; set; }
        public string OwnerOrTenant { get; set; }

        public Apartment(int ıd, string block, string status, string type, int floor, int apartmentNumber, string ownerOrTenant)
        {
            Id = ıd;
            Block = block;
            Status = status;
            Type = type;
            Floor = floor;
            ApartmentNumber = apartmentNumber;
            OwnerOrTenant = ownerOrTenant;
        }

       
    }

}
