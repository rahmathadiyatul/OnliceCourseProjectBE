using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SoupLocal._1_Core.Entities.SubEntities;
using SoupLocal._1_Core.Entities;
using SoupLocal._2_Service.Service.Interface;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using System;
using SoupLocal._2_Service.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace SoupLocal.Controllers
{
    [ApiController]
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly IConfiguration _config;
        public CartController(ICartService cartService, IConfiguration config)
        {
            this.cartService = cartService;
            _config = config;
        }

        [Route("Api/[controller]/Create")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Cart cart)
        {

            var result = await cartService.CreateCart(cart);
            if (result == true)
            {
                return Ok(result);
            } else
            {
                return BadRequest(new Exception("Server Error!"));
            }
        }
/*        [Route("Api/[controller]/Get")]
        [HttpPost]
        public async Task<CartContent> Get([FromBody] int userId)
        {
            var result = await cartService.GetCartByUserId(userId);
            return result;
        }*/
    }
}
