using IC.DotNet.Interview.Core.Database;
using IC.DotNet.Interview.Core.Repositories;
using IC.DotNet.Interview.Logic.BL;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace IC.DotNet.Interview.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            container.RegisterType<IDbContext, DbContext>();

            container.RegisterType<ITaskRepository, TaskRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();

            container.RegisterType<ITaskLogic, TaskLogic>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}