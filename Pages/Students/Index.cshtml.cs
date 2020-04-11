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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesStudent.Data.RazorPagesStudentContext _context;

        public IndexModel(RazorPagesStudent.Data.RazorPagesStudentContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var students = from m in _context.Student
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                students = students.Where(s => s.name.Substring(0,1).Contains(SearchString.Substring(0,1)) 
                && s.name.Substring(s.name.Length-1,1).Contains(SearchString.Substring(1, 1)) 
                && s.birthDay.Year.ToString().Substring(2,2).Contains(SearchString.Substring(2,2))
                && s.groupNumber.ToString().Contains(SearchString.Substring(4,4)));
            }

            Student = await students.ToListAsync();
        }
    }
}
