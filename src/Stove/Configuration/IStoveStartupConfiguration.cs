﻿using System;
using System.Collections.Generic;

using Autofac.Extras.IocManager;

using Stove.Domain.Uow;

namespace Stove.Configuration
{
    public interface IStoveStartupConfiguration
    {
        IResolver Resolver { get; }

        /// <summary>
        ///     Gets/sets default connection string used by ORM module.
        ///     It can be name of a connection string in application's config file or can be full connection string.
        /// </summary>
        string DefaultNameOrConnectionString { get; set; }

        /// <summary>
        ///     Used to configure unit of work defaults.
        /// </summary>
        IUnitOfWorkDefaultOptions UnitOfWork { get; set; }

        /// <summary>
        ///     Gets or sets the typed connection strings.
        /// </summary>
        /// <value>
        ///     The typed connection strings.
        /// </value>
        Dictionary<Type, string> TypedConnectionStrings { get; set; }
    }
}