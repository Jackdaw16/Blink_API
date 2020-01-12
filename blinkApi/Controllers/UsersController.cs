using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blinkApi.Contexts;
using blinkApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blinkApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : BlinkController
    {
        public UsersController(BlinkDB db) : base(db)
        {
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            try
            {
                List<User> user = await _db.users.ToListAsync();
                
                return user;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}