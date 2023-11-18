using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Student.Controllers
{
    public class StudentControllers : Controller
    {
        private readonly ApplicationDbContext _context;
        public async Task <IActionResult > Index()
        {
            _ = await _context.ToListAsync();
        }


    }
}
