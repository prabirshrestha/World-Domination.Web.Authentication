﻿using System;

namespace WorldDomination.Web.Authentication
{
    public interface IAuthenticatedClient
    {
        ProviderType ProviderType { get; }
        UserInformation UserInformation { get; set; }
        string AccessToken { get; set; }
        DateTime AccessTokenExpiresOn { get; set; }
    }
}