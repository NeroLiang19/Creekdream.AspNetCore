﻿using Creekdream.Dependency;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Creekdream
{
    /// <summary>
    /// Application framework initialization
    /// </summary>
    public class ServicesBuilderOptions
    {
        /// <summary>
        /// Ioc register
        /// </summary>
        public IocRegisterBase IocRegister { get; set; }

        /// <summary>
        /// Build and initialize
        /// </summary>
        public IServiceProvider Build(IServiceCollection services)
        {
            IocRegister.RegisterAssemblyByBasicInterface(GetType().Assembly);
            return IocRegister.GetServiceProvider(services);
        }
    }
}
