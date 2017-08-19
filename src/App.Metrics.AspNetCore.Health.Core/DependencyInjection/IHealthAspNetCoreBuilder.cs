﻿// <copyright file="IHealthAspNetCoreBuilder.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection
    // ReSharper restore CheckNamespace
{
    /// <summary>
    ///     An interface for configuring App Metrics AspNet Core health services.
    /// </summary>
    public interface IHealthAspNetCoreBuilder
    {
        /// <summary>
        ///     Gets the <see cref="IServiceCollection"/> where App Metrics services are configured.
        /// </summary>
        IServiceCollection Services { get; }
    }
}