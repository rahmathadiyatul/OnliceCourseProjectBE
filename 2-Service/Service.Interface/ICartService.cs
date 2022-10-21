using SoupLocal._1_Core.Entities;
using SoupLocal._1_Core.Entities.SubEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoupLocal._2_Service.Service.Interface
{
    public interface ICartService
    {
        public Task<bool> CreateCart(Cart cart);
/*        public Task<CartContent> GetCartByUserId(int userId);
*/    }
}
