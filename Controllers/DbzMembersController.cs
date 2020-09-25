using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace capstone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DbzMembersController : ControllerBase
    {
        private ApplicationDbContext _context;

        public DbzMembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<DbzMember> Get()
        {
            //var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return _context.DbzMembers;
        }
    }
}
