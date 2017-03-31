using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Meter.EntityFramework;

namespace Meter.Migrator
{
    [DependsOn(typeof(MeterDataModule))]
    public class MeterMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MeterDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}