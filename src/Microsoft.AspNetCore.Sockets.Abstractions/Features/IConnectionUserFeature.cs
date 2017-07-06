﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Microsoft.AspNetCore.Sockets.Features
{
    public interface IConnectionUserFeature
    {
        ClaimsPrincipal User { get; set; }
    }
}
