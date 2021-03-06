// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.TestHost;

internal class UpgradeFeature : IHttpUpgradeFeature
{
    public bool IsUpgradableRequest => false;

    // TestHost provides an IHttpWebSocketFeature so it wont call UpgradeAsync()
    public Task<Stream> UpgradeAsync()
    {
        throw new NotSupportedException();
    }
}
