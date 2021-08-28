using System.Collections.Generic;
using System.Linq;
using api.Data;
using api.Entites;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext _context { get; }
        public UsersController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
        return await _context.Users.ToListAsync();
         
        }

         [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
        return await _context.Users.FindAsync(id);
         
        }
    }
}