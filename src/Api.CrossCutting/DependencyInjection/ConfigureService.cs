﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces.Services.User;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using Service.Services.User;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService{

        public static void ConfigureDependenciesService( IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
        }
    }
}
