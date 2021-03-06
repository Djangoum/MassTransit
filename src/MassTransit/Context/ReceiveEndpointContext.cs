﻿// Copyright 2007-2018 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Context
{
    using System;
    using GreenPipes;
    using Pipeline;
    using Topology;
    using Transports;


    /// <summary>
    /// The context of a receive endpoint
    /// </summary>
    public interface ReceiveEndpointContext :
        PipeContext,
        ISendObserverConnector,
        IPublishObserverConnector,
        IReceiveTransportObserverConnector,
        IReceiveObserverConnector,
        IReceiveEndpointObserverConnector
    {
        /// <summary>
        /// The input address of the receive endpoint
        /// </summary>
        Uri InputAddress { get; }

        IReceiveObserver ReceiveObservers { get; }

        IReceiveTransportObserver TransportObservers { get; }

        IReceiveEndpointObserver EndpointObservers { get; }

        IPublishTopology Publish { get; }

        IReceivePipe ReceivePipe { get; }

        ISendEndpointProvider SendEndpointProvider { get; }

        IPublishEndpointProvider PublishEndpointProvider { get; }
        
        IMessageSerializer Serializer { get; }
        ISendPipe SendPipe { get; }
    }
}