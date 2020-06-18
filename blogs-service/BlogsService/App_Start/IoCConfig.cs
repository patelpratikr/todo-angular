using BlogsService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BlogsService.App_Start
{
    public class IoCConfig
    {
        public static void Configure()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<IBlogRepository, BlogRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(unityContainer));
        }
    }
}