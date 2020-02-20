﻿// <copyright file="OktaOAuthException.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Sdk
{
    public class OktaOAuthException : OktaException
    {
        private readonly IOAuthApiError _error;

        public OktaOAuthException(int statusCode, IOAuthApiError error)
            : base(message: $"{error.Error} ({statusCode}, {error.ErrorDescription})")
        {
            StatusCode = statusCode;
            _error = error;
        }

        /// <summary>
        /// Gets the HTTP status code.
        /// </summary>
        /// <value>
        /// The HTTP status code.
        /// </value>
        public int StatusCode { get; }

        /// <summary>
        /// Gets the error code from the <see cref="Error"/> object.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public string Error => _error?.Error;

        /// <summary>
        /// Gets the error code from the <see cref="Error"/> object.
        /// </summary>
        /// <value>
        /// The error description.
        /// </value>
        public string ErrorDescription => _error?.ErrorDescription;
    }
}
