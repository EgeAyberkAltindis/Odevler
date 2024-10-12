using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Aspnetcore.IdentityArea.Models.Context
{
    public class ProjectContext:IdentityDbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options ):base(options)
        {
            
        }
    }
}
