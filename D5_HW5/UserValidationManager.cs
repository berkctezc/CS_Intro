using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            {
                if (player.BirthYear == 1998 && player.FirstName == "Berkcan" && player.LastName == "Tezcaner" && player.IdentityNumber == "12345")
                    return true;
                else 
                    return false;
            }
        }
    }
}
