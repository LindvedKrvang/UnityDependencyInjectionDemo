using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using UnityDependencyInjectionDemo.Services;

namespace UnityDependencyInjectionDemo
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers

			// e.g. container.RegisterType<ITestService, TestService>();

			container.RegisterType<IService, HotdogService>();
			container.RegisterType<IService, IceService>();
			container.RegisterType<IAnnouncer, Announcer>();

			DependencyResolver.SetResolver(new UnityDependencyResolver(container));
		}
	}
}