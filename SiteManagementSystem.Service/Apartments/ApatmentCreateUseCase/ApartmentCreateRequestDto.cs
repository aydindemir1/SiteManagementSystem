using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagementSystem.Service.Apartments.ApatmentCreateUseCase
{
    public record ApartmentCreateRequestDto(string Block, string Status, string Type, int Floor, int ApartmentNumber, string OwnerOrTenant);
}
