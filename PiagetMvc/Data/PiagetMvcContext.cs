using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PiagetMvc.Models;

namespace PiagetMvc.Data
{
    public class PiagetMvcContext : DbContext
    {
        public PiagetMvcContext (DbContextOptions<PiagetMvcContext> options)
            : base(options)
        {
        }

        public DbSet<PiagetMvc.Models.Aluno> Aluno { get; set; } = default!;
    }
}
