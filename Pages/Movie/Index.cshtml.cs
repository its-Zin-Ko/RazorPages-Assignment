using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RzAssignment.Data;
using RzAssignment.Models;

namespace RzAssignment.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly RzAssignment.Data.RzAssignmentContext _context;

        public IndexModel(RzAssignment.Data.RzAssignmentContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Name { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieName { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movies
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Name.Contains(SearchString));
            }

            Movies = await movies.ToListAsync();
        }
    }
}
