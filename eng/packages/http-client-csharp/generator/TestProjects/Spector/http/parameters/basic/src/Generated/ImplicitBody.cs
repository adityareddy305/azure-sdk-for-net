// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Parameters.Basic
{
    public partial class ImplicitBody
    {
        protected ImplicitBody() => throw null;

        public HttpPipeline Pipeline => throw null;

        public virtual Response Simple(RequestContent content, RequestContext context = null) => throw null;

        public virtual Task<Response> SimpleAsync(RequestContent content, RequestContext context = null) => throw null;

        public virtual Response Simple(string name, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> SimpleAsync(string name, CancellationToken cancellationToken = default) => throw null;
    }
}
