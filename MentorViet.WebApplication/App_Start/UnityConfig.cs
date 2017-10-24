using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using MentorViet.Contract;
using MentorViet.Service;
using MentorViet.Entity;

namespace MentorViet.WebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterInstance(new MentorVietContext());
            container.RegisterType<IUserProfileService, UserProfileService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}