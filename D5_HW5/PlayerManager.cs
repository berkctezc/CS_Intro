using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.Validate(player))
                Console.WriteLine("kayıt gerçekleşti");
            else
                Console.WriteLine("kayıt başarısız");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("kayıt silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
