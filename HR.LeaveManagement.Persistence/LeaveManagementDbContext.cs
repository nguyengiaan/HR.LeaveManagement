using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagement.Persistence
{
    public class LeaveManagementDbContext : DbContext // Ensure LeaveManagementDbContext inherits from DbContext  
    {
        public LeaveManagementDbContext(DbContextOptions<LeaveManagementDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveManagementDbContext).Assembly);
        }

        public DbSet<LeaveRequest> LeaveRequests { get; set; } = null!; // Use null-forgiving operator to suppress CS8618  
        public DbSet<LeaveType> LeaveTypes { get; set; } = null!; // Use null-forgiving operator to suppress CS8618  
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; } = null!; // Use null-forgiving operator to suppress CS8618  
    }
}
