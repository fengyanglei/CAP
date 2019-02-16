﻿// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Primitives;

// ReSharper disable once CheckNamespace
namespace DotNetCore.CAP
{
    /// <summary>
    /// Provides programmatic configuration for the CAP Azure Service Bus project.
    /// </summary>
    public class AzureServiceBusOptions
    {
        /// <summary>
        /// TopicPath default value for CAP.
        /// </summary>
        public const string DefaultTopicPath = "cap";

        public int ConnectionPoolSize { get; set; } = 10;

        /// <summary>
        /// Azure Service Bus Namespace connection string. Must not contain topic information.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// The name of the topic relative to the service namespace base address.
        /// </summary>
        public string TopicPath { get; set; } = DefaultTopicPath;

        /// <summary>
        /// Represents the Azure Active Directory token provider for Azure Managed Service Identity integration.
        /// </summary>
        public ITokenProvider ManagementTokenProvider { get; set; }

        /// <summary>
        /// Used to generate Service Bus connection strings
        /// </summary>
        public ServiceBusConnectionStringBuilder ConnectionStringBuilder { get; set; }
    }
}