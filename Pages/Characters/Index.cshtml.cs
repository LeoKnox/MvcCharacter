using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Data;
using MvcCharacter.Models;

namespace MvcCharacter
{
    public class IndexModel : PageModel
    {
        private readonly MvcCharacter.Data.MvcCharacter223Context _context;

        public IndexModel(MvcCharacter.Data.MvcCharacter223Context context)
        {
            _context = context;
        }

        public IList<Character> Character { get;set; }

        public async Task OnGetAsync()
        {
            Character = await _context.Character.ToListAsync();
        }
    }
}
