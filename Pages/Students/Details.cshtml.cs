using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesStudent.Data;
using RazorPagesStudent.Models;

namespace RazorPagesStudent.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesStudent.Data.RazorPagesStudentContext _context;

        public DetailsModel(RazorPagesStudent.Data.RazorPagesStudentContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
