﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace Microsoft.BridgeToKubernetes.Common.EndpointManager
{
    /// <summary>
    /// Request sent to the EndpointManager
    /// </summary>
    public class EndpointManagerRequest
    {
        /// <summary>
        /// The EndpointManager API to call, from <see cref="Constants.EndpointManager.ApiNames"/>
        /// </summary>
        [JsonProperty("apiname")]
        public string ApiName { get; set; }

        /// <summary>
        /// The correlationId for the current call
        /// </summary>
        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }
    }

    /// <summary>
    /// A request sent to the EndpointManager with an argument of type <typeparamref name="T"/>
    /// </summary>
    public class EndpointManagerRequest<T> : EndpointManagerRequest
    {
        /// <summary>
        /// Argument of type <typeparamref name="T"/> passed to the <see cref="EndpointManagerRequest.ApiName"/> API on the EndpointManager
        /// </summary>
        public T Argument { get; set; }
    }
}