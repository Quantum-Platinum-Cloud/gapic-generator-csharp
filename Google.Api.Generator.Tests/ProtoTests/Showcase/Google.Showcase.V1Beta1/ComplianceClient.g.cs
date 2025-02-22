// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Showcase.V1Beta1
{
    /// <summary>Settings for <see cref="ComplianceClient"/> instances.</summary>
    public sealed partial class ComplianceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ComplianceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ComplianceSettings"/>.</returns>
        public static ComplianceSettings GetDefault() => new ComplianceSettings();

        /// <summary>Constructs a new <see cref="ComplianceSettings"/> object with default settings.</summary>
        public ComplianceSettings()
        {
        }

        private ComplianceSettings(ComplianceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RepeatDataBodySettings = existing.RepeatDataBodySettings;
            RepeatDataBodyInfoSettings = existing.RepeatDataBodyInfoSettings;
            RepeatDataQuerySettings = existing.RepeatDataQuerySettings;
            RepeatDataSimplePathSettings = existing.RepeatDataSimplePathSettings;
            RepeatDataPathResourceSettings = existing.RepeatDataPathResourceSettings;
            RepeatDataPathTrailingResourceSettings = existing.RepeatDataPathTrailingResourceSettings;
            RepeatDataBodyPutSettings = existing.RepeatDataBodyPutSettings;
            RepeatDataBodyPatchSettings = existing.RepeatDataBodyPatchSettings;
            GetEnumSettings = existing.GetEnumSettings;
            VerifyEnumSettings = existing.VerifyEnumSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ComplianceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataBody</c> and <c>ComplianceClient.RepeatDataBodyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataBodySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataBodyInfo</c> and <c>ComplianceClient.RepeatDataBodyInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataBodyInfoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataQuery</c> and <c>ComplianceClient.RepeatDataQueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataQuerySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataSimplePath</c> and <c>ComplianceClient.RepeatDataSimplePathAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataSimplePathSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataPathResource</c> and <c>ComplianceClient.RepeatDataPathResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataPathResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataPathTrailingResource</c> and
        /// <c>ComplianceClient.RepeatDataPathTrailingResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataPathTrailingResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataBodyPut</c> and <c>ComplianceClient.RepeatDataBodyPutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataBodyPutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ComplianceClient.RepeatDataBodyPatch</c> and <c>ComplianceClient.RepeatDataBodyPatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RepeatDataBodyPatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ComplianceClient.GetEnum</c>
        ///  and <c>ComplianceClient.GetEnumAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEnumSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ComplianceClient.VerifyEnum</c>
        ///  and <c>ComplianceClient.VerifyEnumAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings VerifyEnumSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ComplianceSettings"/> object.</returns>
        public ComplianceSettings Clone() => new ComplianceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ComplianceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ComplianceClientBuilder : gaxgrpc::ClientBuilderBase<ComplianceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ComplianceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ComplianceClientBuilder() : base(ComplianceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ComplianceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ComplianceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ComplianceClient Build()
        {
            ComplianceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ComplianceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ComplianceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ComplianceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ComplianceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ComplianceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ComplianceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ComplianceClient.ChannelPool;
    }

    /// <summary>Compliance client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service is used to test that GAPICs implement various REST-related features correctly. This mostly means transcoding proto3 requests to REST format
    /// correctly for various types of HTTP annotations, but it also includes verifying that unknown (numeric) enums received by clients can be round-tripped
    /// correctly.
    /// </remarks>
    public abstract partial class ComplianceClient
    {
        /// <summary>
        /// The default endpoint for the Compliance service, which is a host of "localhost:7469" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "localhost:7469:443";

        /// <summary>The default Compliance scopes.</summary>
        /// <remarks>The default Compliance scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Compliance.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ComplianceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ComplianceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ComplianceClient"/>.</returns>
        public static stt::Task<ComplianceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ComplianceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ComplianceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="ComplianceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ComplianceClient"/>.</returns>
        public static ComplianceClient Create() => new ComplianceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ComplianceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ComplianceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ComplianceClient"/>.</returns>
        internal static ComplianceClient Create(grpccore::CallInvoker callInvoker, ComplianceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Compliance.ComplianceClient grpcClient = new Compliance.ComplianceClient(callInvoker);
            return new ComplianceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC Compliance client</summary>
        public virtual Compliance.ComplianceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the entire request object in the REST body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataBody(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the entire request object in the REST body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the entire request object in the REST body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataBodyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the a message-type field in the REST body. Per AIP-127, only
        /// top-level, non-repeated fields can be sent this way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataBodyInfo(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the a message-type field in the REST body. Per AIP-127, only
        /// top-level, non-repeated fields can be sent this way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyInfoAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the a message-type field in the REST body. Per AIP-127, only
        /// top-level, non-repeated fields can be sent this way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyInfoAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataBodyInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending all request fields as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataQuery(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending all request fields as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataQueryAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending all request fields as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataQueryAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending some parameters as "simple" path variables (i.e., of the form
        /// "/bar/{foo}" rather than "/{foo=bar/*}"), and the rest as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataSimplePath(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending some parameters as "simple" path variables (i.e., of the form
        /// "/bar/{foo}" rather than "/{foo=bar/*}"), and the rest as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataSimplePathAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending some parameters as "simple" path variables (i.e., of the form
        /// "/bar/{foo}" rather than "/{foo=bar/*}"), and the rest as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataSimplePathAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataSimplePathAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a path resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataPathResource(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a path resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataPathResourceAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a path resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataPathResourceAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataPathResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a trailing resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataPathTrailingResource(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a trailing resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataPathTrailingResourceAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a trailing resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataPathTrailingResourceAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataPathTrailingResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PUT method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataBodyPut(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PUT method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyPutAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PUT method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyPutAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataBodyPutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PATCH method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RepeatResponse RepeatDataBodyPatch(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PATCH method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyPatchAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PATCH method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RepeatResponse> RepeatDataBodyPatchAsync(RepeatRequest request, st::CancellationToken cancellationToken) =>
            RepeatDataBodyPatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method requests an enum value from the server. Depending on the contents of EnumRequest, the enum value returned will be a known enum declared in the
        /// .proto file, or a made-up enum value the is unknown to the client. To verify that clients can round-trip unknown enum vaues they receive, use the
        /// response from this RPC as the request to VerifyEnum()
        /// 
        /// The values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run (this is needed for
        /// VerifyEnum() to work) but are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EnumResponse GetEnum(EnumRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method requests an enum value from the server. Depending on the contents of EnumRequest, the enum value returned will be a known enum declared in the
        /// .proto file, or a made-up enum value the is unknown to the client. To verify that clients can round-trip unknown enum vaues they receive, use the
        /// response from this RPC as the request to VerifyEnum()
        /// 
        /// The values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run (this is needed for
        /// VerifyEnum() to work) but are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnumResponse> GetEnumAsync(EnumRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method requests an enum value from the server. Depending on the contents of EnumRequest, the enum value returned will be a known enum declared in the
        /// .proto file, or a made-up enum value the is unknown to the client. To verify that clients can round-trip unknown enum vaues they receive, use the
        /// response from this RPC as the request to VerifyEnum()
        /// 
        /// The values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run (this is needed for
        /// VerifyEnum() to work) but are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnumResponse> GetEnumAsync(EnumRequest request, st::CancellationToken cancellationToken) =>
            GetEnumAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method is used to verify that clients can round-trip enum values, which is particularly important for unknown enum values over REST. VerifyEnum()
        /// verifies that its request, which is presumably the response that the client previously got to a GetEnum(), contains the correct data. If so, it responds
        /// with the same EnumResponse; otherwise, the RPC errors.
        /// 
        /// This works because the values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run,
        /// although they are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EnumResponse VerifyEnum(EnumResponse request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method is used to verify that clients can round-trip enum values, which is particularly important for unknown enum values over REST. VerifyEnum()
        /// verifies that its request, which is presumably the response that the client previously got to a GetEnum(), contains the correct data. If so, it responds
        /// with the same EnumResponse; otherwise, the RPC errors.
        /// 
        /// This works because the values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run,
        /// although they are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnumResponse> VerifyEnumAsync(EnumResponse request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method is used to verify that clients can round-trip enum values, which is particularly important for unknown enum values over REST. VerifyEnum()
        /// verifies that its request, which is presumably the response that the client previously got to a GetEnum(), contains the correct data. If so, it responds
        /// with the same EnumResponse; otherwise, the RPC errors.
        /// 
        /// This works because the values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run,
        /// although they are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnumResponse> VerifyEnumAsync(EnumResponse request, st::CancellationToken cancellationToken) =>
            VerifyEnumAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Compliance client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service is used to test that GAPICs implement various REST-related features correctly. This mostly means transcoding proto3 requests to REST format
    /// correctly for various types of HTTP annotations, but it also includes verifying that unknown (numeric) enums received by clients can be round-tripped
    /// correctly.
    /// </remarks>
    public sealed partial class ComplianceClientImpl : ComplianceClient
    {
        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataBody;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataBodyInfo;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataQuery;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataSimplePath;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataPathResource;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataPathTrailingResource;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataBodyPut;

        private readonly gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> _callRepeatDataBodyPatch;

        private readonly gaxgrpc::ApiCall<EnumRequest, EnumResponse> _callGetEnum;

        private readonly gaxgrpc::ApiCall<EnumResponse, EnumResponse> _callVerifyEnum;

        /// <summary>
        /// Constructs a client wrapper for the Compliance service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ComplianceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ComplianceClientImpl(Compliance.ComplianceClient grpcClient, ComplianceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ComplianceSettings effectiveSettings = settings ?? ComplianceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callRepeatDataBody = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataBody", grpcClient.RepeatDataBodyAsync, grpcClient.RepeatDataBody, effectiveSettings.RepeatDataBodySettings);
            Modify_ApiCall(ref _callRepeatDataBody);
            Modify_RepeatDataBodyApiCall(ref _callRepeatDataBody);
            _callRepeatDataBodyInfo = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataBodyInfo", grpcClient.RepeatDataBodyInfoAsync, grpcClient.RepeatDataBodyInfo, effectiveSettings.RepeatDataBodyInfoSettings);
            Modify_ApiCall(ref _callRepeatDataBodyInfo);
            Modify_RepeatDataBodyInfoApiCall(ref _callRepeatDataBodyInfo);
            _callRepeatDataQuery = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataQuery", grpcClient.RepeatDataQueryAsync, grpcClient.RepeatDataQuery, effectiveSettings.RepeatDataQuerySettings);
            Modify_ApiCall(ref _callRepeatDataQuery);
            Modify_RepeatDataQueryApiCall(ref _callRepeatDataQuery);
            _callRepeatDataSimplePath = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataSimplePath", grpcClient.RepeatDataSimplePathAsync, grpcClient.RepeatDataSimplePath, effectiveSettings.RepeatDataSimplePathSettings).WithGoogleRequestParam("info.f_string", request => request.Info?.FString).WithGoogleRequestParam("info.f_int32", request => gaxgrpc::RoutingHeaderExtractor<RepeatRequest>.FormatRoutingHeaderValue(request.Info?.FInt32)).WithGoogleRequestParam("info.f_double", request => gaxgrpc::RoutingHeaderExtractor<RepeatRequest>.FormatRoutingHeaderValue(request.Info?.FDouble)).WithGoogleRequestParam("info.f_bool", request => gaxgrpc::RoutingHeaderExtractor<RepeatRequest>.FormatRoutingHeaderValue(request.Info?.FBool)).WithGoogleRequestParam("info.f_kingdom", request => gaxgrpc::RoutingHeaderExtractor<RepeatRequest>.FormatRoutingHeaderValue(request.Info?.FKingdom));
            Modify_ApiCall(ref _callRepeatDataSimplePath);
            Modify_RepeatDataSimplePathApiCall(ref _callRepeatDataSimplePath);
            _callRepeatDataPathResource = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataPathResource", grpcClient.RepeatDataPathResourceAsync, grpcClient.RepeatDataPathResource, effectiveSettings.RepeatDataPathResourceSettings).WithGoogleRequestParam("info.f_string", request => request.Info?.FString).WithGoogleRequestParam("info.f_child.f_string", request => request.Info?.FChild?.FString).WithGoogleRequestParam("info.f_bool", request => gaxgrpc::RoutingHeaderExtractor<RepeatRequest>.FormatRoutingHeaderValue(request.Info?.FBool));
            Modify_ApiCall(ref _callRepeatDataPathResource);
            Modify_RepeatDataPathResourceApiCall(ref _callRepeatDataPathResource);
            _callRepeatDataPathTrailingResource = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataPathTrailingResource", grpcClient.RepeatDataPathTrailingResourceAsync, grpcClient.RepeatDataPathTrailingResource, effectiveSettings.RepeatDataPathTrailingResourceSettings).WithGoogleRequestParam("info.f_string", request => request.Info?.FString).WithGoogleRequestParam("info.f_child.f_string", request => request.Info?.FChild?.FString);
            Modify_ApiCall(ref _callRepeatDataPathTrailingResource);
            Modify_RepeatDataPathTrailingResourceApiCall(ref _callRepeatDataPathTrailingResource);
            _callRepeatDataBodyPut = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataBodyPut", grpcClient.RepeatDataBodyPutAsync, grpcClient.RepeatDataBodyPut, effectiveSettings.RepeatDataBodyPutSettings);
            Modify_ApiCall(ref _callRepeatDataBodyPut);
            Modify_RepeatDataBodyPutApiCall(ref _callRepeatDataBodyPut);
            _callRepeatDataBodyPatch = clientHelper.BuildApiCall<RepeatRequest, RepeatResponse>("RepeatDataBodyPatch", grpcClient.RepeatDataBodyPatchAsync, grpcClient.RepeatDataBodyPatch, effectiveSettings.RepeatDataBodyPatchSettings);
            Modify_ApiCall(ref _callRepeatDataBodyPatch);
            Modify_RepeatDataBodyPatchApiCall(ref _callRepeatDataBodyPatch);
            _callGetEnum = clientHelper.BuildApiCall<EnumRequest, EnumResponse>("GetEnum", grpcClient.GetEnumAsync, grpcClient.GetEnum, effectiveSettings.GetEnumSettings);
            Modify_ApiCall(ref _callGetEnum);
            Modify_GetEnumApiCall(ref _callGetEnum);
            _callVerifyEnum = clientHelper.BuildApiCall<EnumResponse, EnumResponse>("VerifyEnum", grpcClient.VerifyEnumAsync, grpcClient.VerifyEnum, effectiveSettings.VerifyEnumSettings);
            Modify_ApiCall(ref _callVerifyEnum);
            Modify_VerifyEnumApiCall(ref _callVerifyEnum);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RepeatDataBodyApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataBodyInfoApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataQueryApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataSimplePathApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataPathResourceApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataPathTrailingResourceApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataBodyPutApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_RepeatDataBodyPatchApiCall(ref gaxgrpc::ApiCall<RepeatRequest, RepeatResponse> call);

        partial void Modify_GetEnumApiCall(ref gaxgrpc::ApiCall<EnumRequest, EnumResponse> call);

        partial void Modify_VerifyEnumApiCall(ref gaxgrpc::ApiCall<EnumResponse, EnumResponse> call);

        partial void OnConstruction(Compliance.ComplianceClient grpcClient, ComplianceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Compliance client</summary>
        public override Compliance.ComplianceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_RepeatRequest(ref RepeatRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnumRequest(ref EnumRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnumResponse(ref EnumResponse request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the entire request object in the REST body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataBody(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBody.Sync(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the entire request object in the REST body.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataBodyAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBody.Async(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the a message-type field in the REST body. Per AIP-127, only
        /// top-level, non-repeated fields can be sent this way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataBodyInfo(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBodyInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending the a message-type field in the REST body. Per AIP-127, only
        /// top-level, non-repeated fields can be sent this way.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataBodyInfoAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBodyInfo.Async(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending all request fields as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataQuery(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending all request fields as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataQueryAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataQuery.Async(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending some parameters as "simple" path variables (i.e., of the form
        /// "/bar/{foo}" rather than "/{foo=bar/*}"), and the rest as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataSimplePath(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataSimplePath.Sync(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request. This method exercises
        /// sending some parameters as "simple" path variables (i.e., of the form
        /// "/bar/{foo}" rather than "/{foo=bar/*}"), and the rest as query parameters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataSimplePathAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataSimplePath.Async(request, callSettings);
        }

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a path resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataPathResource(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataPathResource.Sync(request, callSettings);
        }

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a path resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataPathResourceAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataPathResource.Async(request, callSettings);
        }

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a trailing resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataPathTrailingResource(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataPathTrailingResource.Sync(request, callSettings);
        }

        /// <summary>
        /// Same as RepeatDataSimplePath, but with a trailing resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataPathTrailingResourceAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataPathTrailingResource.Async(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PUT method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataBodyPut(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBodyPut.Sync(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PUT method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataBodyPutAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBodyPut.Async(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PATCH method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RepeatResponse RepeatDataBodyPatch(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBodyPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// This method echoes the ComplianceData request, using the HTTP PATCH method.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RepeatResponse> RepeatDataBodyPatchAsync(RepeatRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RepeatRequest(ref request, ref callSettings);
            return _callRepeatDataBodyPatch.Async(request, callSettings);
        }

        /// <summary>
        /// This method requests an enum value from the server. Depending on the contents of EnumRequest, the enum value returned will be a known enum declared in the
        /// .proto file, or a made-up enum value the is unknown to the client. To verify that clients can round-trip unknown enum vaues they receive, use the
        /// response from this RPC as the request to VerifyEnum()
        /// 
        /// The values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run (this is needed for
        /// VerifyEnum() to work) but are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EnumResponse GetEnum(EnumRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnumRequest(ref request, ref callSettings);
            return _callGetEnum.Sync(request, callSettings);
        }

        /// <summary>
        /// This method requests an enum value from the server. Depending on the contents of EnumRequest, the enum value returned will be a known enum declared in the
        /// .proto file, or a made-up enum value the is unknown to the client. To verify that clients can round-trip unknown enum vaues they receive, use the
        /// response from this RPC as the request to VerifyEnum()
        /// 
        /// The values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run (this is needed for
        /// VerifyEnum() to work) but are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EnumResponse> GetEnumAsync(EnumRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnumRequest(ref request, ref callSettings);
            return _callGetEnum.Async(request, callSettings);
        }

        /// <summary>
        /// This method is used to verify that clients can round-trip enum values, which is particularly important for unknown enum values over REST. VerifyEnum()
        /// verifies that its request, which is presumably the response that the client previously got to a GetEnum(), contains the correct data. If so, it responds
        /// with the same EnumResponse; otherwise, the RPC errors.
        /// 
        /// This works because the values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run,
        /// although they are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EnumResponse VerifyEnum(EnumResponse request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnumResponse(ref request, ref callSettings);
            return _callVerifyEnum.Sync(request, callSettings);
        }

        /// <summary>
        /// This method is used to verify that clients can round-trip enum values, which is particularly important for unknown enum values over REST. VerifyEnum()
        /// verifies that its request, which is presumably the response that the client previously got to a GetEnum(), contains the correct data. If so, it responds
        /// with the same EnumResponse; otherwise, the RPC errors.
        /// 
        /// This works because the values of enums sent by the server when a known or unknown value is requested will be the same within a single Showcase server run,
        /// although they are not guaranteed to be the same across separate Showcase server runs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EnumResponse> VerifyEnumAsync(EnumResponse request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnumResponse(ref request, ref callSettings);
            return _callVerifyEnum.Async(request, callSettings);
        }
    }

    public static partial class Compliance
    {
        public partial class ComplianceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
