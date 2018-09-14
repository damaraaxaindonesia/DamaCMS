

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Repository;
using DamaCoreCMS.Framework.Setup;

namespace DamaCoreCMS.Framework.Core.App
{
    public class NetCoreStartup
    {
        public void SelectDatabase(IServiceCollection services)
        {

            #region Database Selection

            if (SetupHelper.SelectedDatabase == "SqLite")
            {
                services.AddDbContext<NccDbContext>(options =>
                    options.UseSqlite(SetupHelper.ConnectionString, opt => { opt.MigrationsAssembly("DamaCoreCMS.Framework"); opt.MigrationsHistoryTable(SetupHelper.TablePrefix + "ef_migration_history"); }), ServiceLifetime.Scoped, ServiceLifetime.Scoped
                );
            }
            else if (SetupHelper.SelectedDatabase == "MSSQL")
            {
                services.AddDbContext<NccDbContext>(options =>
                    options.UseSqlServer(SetupHelper.ConnectionString, opt => { opt.MigrationsAssembly("DamaCoreCMS.Framework"); opt.MigrationsHistoryTable(SetupHelper.TablePrefix + "ef_migration_history"); }), ServiceLifetime.Scoped, ServiceLifetime.Scoped
                );
            }
            else if (SetupHelper.SelectedDatabase == "MySql")
            {
                services.AddDbContext<NccDbContext>(options => {
                    options.UseMySql(SetupHelper.ConnectionString, opt => { opt.MigrationsAssembly("DamaCoreCMS.Framework"); opt.MigrationsHistoryTable(SetupHelper.TablePrefix + "ef_migration_history"); }); 
                }, ServiceLifetime.Scoped, ServiceLifetime.Scoped);
                
            }
            else
            {
                services.AddDbContext<NccDbContext>(options =>
                    options.UseInMemoryDatabase("DamaCoreCMS")
                );
            }

            #endregion
        }
    }
}
