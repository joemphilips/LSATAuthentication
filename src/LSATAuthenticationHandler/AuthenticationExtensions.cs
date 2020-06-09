using System;
using System.Collections.Generic;
using System.Linq;
using DotNetLightning.Payment.LSAT;
using Macaroons;
using Microsoft.AspNetCore.Authentication;
using NBitcoin;

namespace LSATAuthenticationHandler
{
    public static class AuthenticationExtensions
    {
        /// <summary>
        /// See <see cref="LSATAuthenticationHandler"/>
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configureOptions"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddLSATAuthentication(this AuthenticationBuilder builder,
            Action<LSATAuthenticationOptions> configureOptions)
        {
            return builder.AddScheme<LSATAuthenticationOptions, LSATAuthenticationHandler>(LSATDefaults.Scheme, configureOptions);
        }
        /// <summary>
        /// See <see cref="LSATAuthenticationHandler"/>
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static AuthenticationBuilder AddLSATAuthentication(this AuthenticationBuilder builder)
        {
            return builder.AddScheme<LSATAuthenticationOptions, LSATAuthenticationHandler>(LSATDefaults.Scheme, null);
        }
    }
}