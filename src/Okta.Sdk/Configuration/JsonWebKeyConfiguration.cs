﻿// <copyright file="JsonWebKeyConfiguration.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;
using Newtonsoft.Json;

namespace Okta.Sdk.Configuration
{
    /// <summary>
    /// JWK configuration for private key when using OAuth strategy.
    /// </summary>
    public class JsonWebKeyConfiguration
    {
        /// <summary>
        /// Gets or sets the key id. Optional.
        /// </summary>
        [JsonProperty("kid")]
        public string Kid { get; set; }

        /// <summary>
        /// Gets or sets the key type.
        /// </summary>
        [JsonProperty("kty")]
        public string Kty { get; set; }

        /// <summary>
        /// Gets or sets the RSA modulus
        /// </summary>
        [JsonProperty("n")]
        public string N { get; set; }

        /// <summary>
        /// Gets or sets the RSA public exponent
        /// </summary>
        [JsonProperty("e")]
        public string E { get; set; }

        /// <summary>
        /// Gets or sets the RSA secret prime 'p'
        /// </summary>
        [JsonProperty("p")]
        public string P { get; set; }

        /// <summary>
        /// Gets or sets the RSA secret prime 'q'
        /// </summary>
        [JsonProperty("q")]
        public string Q { get; set; }

        /// <summary>
        /// Gets or sets the RSA 'qi' parameter.
        /// </summary>
        [JsonProperty("qi")]
        public string Qi { get; set; }

        /// <summary>
        /// Gets or sets the RSA exponent 'dq'
        /// </summary>
        [JsonProperty("dq")]
        public string Dq { get; set; }

        /// <summary>
        /// Gets or sets the RSA exponent 'dp'
        /// </summary>
        [JsonProperty("dp")]
        public string Dp { get; set; }

        /// <summary>
        /// Gets or sets the 'd' parameter. EC Private Key or RSA Private Exponent.
        /// </summary>
        [JsonProperty("d")]
        public string D { get; set; }

        /// <summary>
        /// Gets or sets the elliptic curve field and equation used
        /// </summary>
        [JsonProperty("crv")]
        public string Crv { get; set; }

        /// <summary>
        /// Gets or sets the 'x' coordinate for the elliptic curve point
        /// </summary>
        [JsonProperty("x")]
        public string X { get; set; }

        /// <summary>
        /// Gets or sets the 'y' coordinate for the elliptic curve point
        /// </summary>
        [JsonProperty("y")]
        public string Y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWebKeyConfiguration"/> class.
        /// </summary>
        public JsonWebKeyConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonWebKeyConfiguration"/> class.
        /// </summary>
        /// <param name="json">The private key in json format.</param>
        public JsonWebKeyConfiguration(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                throw new ArgumentNullException(nameof(json), "The json parameter cannot be null.");
            }

            try
            {
                JsonConvert.PopulateObject(json, this);
            }
            catch (Exception e)
            {
                throw new ArgumentException($"The private key provided is invalid. {e.Message}", nameof(json));
            }
        }
    }
}
