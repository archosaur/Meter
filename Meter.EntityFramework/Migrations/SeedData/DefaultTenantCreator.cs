using System.Linq;
using Meter.EntityFramework;
using Meter.MultiTenancy;

namespace Meter.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MeterDbContext _context;

        public DefaultTenantCreator(MeterDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
