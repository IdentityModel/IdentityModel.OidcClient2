﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System.Collections.Generic;

namespace IdentityModel.OidcClient
{
    public class Policy
    {
        // discovery document
        public bool ValidateIssuerName { get; set; } = true;
        public bool ValidateEndpoints { get; set; } = true;
        public bool RequireHttps { get; set; } = true;

        public bool RequireCodeHash { get; set; } = true;
        public bool RequireAccessTokenHash { get; set; } = true;

        public bool RequireIdentityTokenOnRefreshTokenResponse { get; set; } = true;

        public ICollection<string> SupportedAlgorithms { get; set; } = new HashSet<string>
        {
            OidcConstants.Algorithms.Asymmetric.RS256,
            OidcConstants.Algorithms.Asymmetric.RS384,
            OidcConstants.Algorithms.Asymmetric.RS512
        };
    }
}