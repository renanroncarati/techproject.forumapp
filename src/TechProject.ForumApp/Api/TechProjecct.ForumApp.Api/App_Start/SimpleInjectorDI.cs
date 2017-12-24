using ForumApp.Application.Service;
using ForumApp.Application.Service.Interfaces;
using ForumApp.Core.Domain;
using ForumApp.Core.Domain.Repositories;
using ForumApp.Domain.Service.Interfaces;
using ForumApp.Infrasctructure.EntityFramework;
using ForumApp.Infrasctructure.EntityFramework.Repositories;
using ForumApp.Infrastructure.DataTransferObject;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace TechProjecct.ForumApp.Api.App_Start
{
    public class SimpleInjectorDI
    {
        public static Container Register(HttpConfiguration httpConfiguration)
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            container.RegisterWebApiControllers(httpConfiguration);

            // DisposableService implements IDisposable http://simpleinjector.readthedocs.io/en/latest/disposabletransientcomponent.html
            #region Scoped
            container.Register<ForumAppContext, ForumAppContext>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<IUserAppService, UserAppService>(Lifestyle.Scoped);
            container.Register<IPostAppService, PostAppService>(Lifestyle.Scoped);
            container.Register<ITopicAppService, TopicAppService>(Lifestyle.Scoped);
            #endregion

            #region Singleton
            container.Register<IMapper, AutoMapperService>(Lifestyle.Singleton); 
            #endregion

            httpConfiguration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            container.Verify();

            return container;
        }
    }
}