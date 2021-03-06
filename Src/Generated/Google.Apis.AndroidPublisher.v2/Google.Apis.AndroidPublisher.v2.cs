// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.46.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Google Play Developer API Version v2
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/android-publisher'>Google Play Developer API</a>
 *      <tr><th>API Version<td>v2
 *      <tr><th>API Rev<td>20200526 (1972)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/android-publisher'>
 *              https://developers.google.com/android-publisher</a>
 *      <tr><th>Discovery Name<td>androidpublisher
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google Play Developer API can be found at
 * <a href='https://developers.google.com/android-publisher'>https://developers.google.com/android-publisher</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.AndroidPublisher.v2
{
    /// <summary>The AndroidPublisher Service.</summary>
    public class AndroidPublisherService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AndroidPublisherService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AndroidPublisherService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            purchases = new PurchasesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "androidpublisher"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            get { return BaseUriOverride ?? "https://www.googleapis.com/androidpublisher/v2/applications/"; }
        #else
            get { return "https://www.googleapis.com/androidpublisher/v2/applications/"; }
        #endif
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "androidpublisher/v2/applications/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch/androidpublisher/v2"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch/androidpublisher/v2"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Play Developer API.</summary>
        public class Scope
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public static string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Play Developer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your Google Play Developer account</summary>
            public const string Androidpublisher = "https://www.googleapis.com/auth/androidpublisher";

        }



        private readonly PurchasesResource purchases;

        /// <summary>Gets the Purchases resource.</summary>
        public virtual PurchasesResource Purchases
        {
            get { return purchases; }
        }
    }

    ///<summary>A base abstract class for AndroidPublisher requests.</summary>
    public abstract class AndroidPublisherBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new AndroidPublisherBaseServiceRequest instance.</summary>
        protected AndroidPublisherBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AndroidPublisher parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "purchases" collection of methods.</summary>
    public class PurchasesResource
    {
        private const string Resource = "purchases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PurchasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            products = new ProductsResource(service);
            voidedpurchases = new VoidedpurchasesResource(service);

        }

        private readonly ProductsResource products;

        /// <summary>Gets the Products resource.</summary>
        public virtual ProductsResource Products
        {
            get { return products; }
        }

        /// <summary>The "products" collection of methods.</summary>
        public class ProductsResource
        {
            private const string Resource = "products";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProductsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Checks the purchase and consumption status of an inapp item.</summary>
            /// <param name="packageName">The package name of the application the inapp product was sold in (for example,
            /// 'com.some.thing').</param>
            /// <param name="productId">The inapp product SKU (for example,
            /// 'com.some.thing.inapp1').</param>
            /// <param name="token">The token provided to the user's device when the inapp
            /// product was purchased.</param>
            public virtual GetRequest Get(string packageName, string productId, string token)
            {
                return new GetRequest(service, packageName, productId, token);
            }

            /// <summary>Checks the purchase and consumption status of an inapp item.</summary>
            public class GetRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v2.Data.ProductPurchase>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string packageName, string productId, string token)
                    : base(service)
                {
                    PackageName = packageName;
                    ProductId = productId;
                    Token = token;
                    InitParameters();
                }


                /// <summary>The package name of the application the inapp product was sold in (for example,
                /// 'com.some.thing').</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The inapp product SKU (for example, 'com.some.thing.inapp1').</summary>
                [Google.Apis.Util.RequestParameterAttribute("productId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProductId { get; private set; }

                /// <summary>The token provided to the user's device when the inapp product was purchased.</summary>
                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Token { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "get"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "{packageName}/purchases/products/{productId}/tokens/{token}"; }
                }

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "productId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "productId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "token", new Google.Apis.Discovery.Parameter
                        {
                            Name = "token",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
        private readonly VoidedpurchasesResource voidedpurchases;

        /// <summary>Gets the Voidedpurchases resource.</summary>
        public virtual VoidedpurchasesResource Voidedpurchases
        {
            get { return voidedpurchases; }
        }

        /// <summary>The "voidedpurchases" collection of methods.</summary>
        public class VoidedpurchasesResource
        {
            private const string Resource = "voidedpurchases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VoidedpurchasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Lists the purchases that were canceled, refunded or charged-back.</summary>
            /// <param name="packageName">The package name of the application for which voided purchases need to be returned (for
            /// example, 'com.some.thing').</param>
            public virtual ListRequest List(string packageName)
            {
                return new ListRequest(service, packageName);
            }

            /// <summary>Lists the purchases that were canceled, refunded or charged-back.</summary>
            public class ListRequest : AndroidPublisherBaseServiceRequest<Google.Apis.AndroidPublisher.v2.Data.VoidedPurchasesListResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string packageName)
                    : base(service)
                {
                    PackageName = packageName;
                    InitParameters();
                }


                /// <summary>The package name of the application for which voided purchases need to be returned (for
                /// example, 'com.some.thing').</summary>
                [Google.Apis.Util.RequestParameterAttribute("packageName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string PackageName { get; private set; }

                /// <summary>The time, in milliseconds since the Epoch, of the newest voided purchase that you want to
                /// see in the response. The value of this parameter cannot be greater than the current time and is
                /// ignored if a pagination token is set. Default value is current time. Note: This filter is applied on
                /// the time at which the record is seen as voided by our systems and not the actual voided time
                /// returned in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> EndTime { get; set; }


                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> MaxResults { get; set; }


                [Google.Apis.Util.RequestParameterAttribute("startIndex", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartIndex { get; set; }

                /// <summary>The time, in milliseconds since the Epoch, of the oldest voided purchase that you want to
                /// see in the response. The value of this parameter cannot be older than 30 days and is ignored if a
                /// pagination token is set. Default value is current time minus 30 days. Note: This filter is applied
                /// on the time at which the record is seen as voided by our systems and not the actual voided time
                /// returned in the response.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<long> StartTime { get; set; }


                [Google.Apis.Util.RequestParameterAttribute("token", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Token { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "list"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "{packageName}/purchases/voidedpurchases"; }
                }

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "packageName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "packageName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "maxResults", new Google.Apis.Discovery.Parameter
                        {
                            Name = "maxResults",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "startIndex", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startIndex",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "token", new Google.Apis.Discovery.Parameter
                        {
                            Name = "token",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
    }
}

namespace Google.Apis.AndroidPublisher.v2.Data
{    

    public class PageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("resultPerPage")]
        public virtual System.Nullable<int> ResultPerPage { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("startIndex")]
        public virtual System.Nullable<int> StartIndex { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("totalResults")]
        public virtual System.Nullable<int> TotalResults { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A ProductPurchase resource indicates the status of a user's inapp product purchase.</summary>
    public class ProductPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The consumption state of the inapp product. Possible values are: - Yet to be consumed -
        /// Consumed</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumptionState")]
        public virtual System.Nullable<int> ConsumptionState { get; set; } 

        /// <summary>A developer-specified string that contains supplemental information about an order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerPayload")]
        public virtual string DeveloperPayload { get; set; } 

        /// <summary>This kind represents an inappPurchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The order id associated with the purchase of the inapp product.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderId")]
        public virtual string OrderId { get; set; } 

        /// <summary>The purchase state of the order. Possible values are: - Purchased - Canceled - Pending</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseState")]
        public virtual System.Nullable<int> PurchaseState { get; set; } 

        /// <summary>The time the product was purchased, in milliseconds since the epoch (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTimeMillis")]
        public virtual System.Nullable<long> PurchaseTimeMillis { get; set; } 

        /// <summary>The type of purchase of the inapp product. This field is only set if this purchase was not made
        /// using the standard in-app billing flow. Possible values are: - Test (i.e. purchased from a license testing
        /// account) - Promo (i.e. purchased using a promo code) - Rewarded (i.e. from watching a video ad instead of
        /// paying)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseType")]
        public virtual System.Nullable<int> PurchaseType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class TokenPagination : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("previousPageToken")]
        public virtual string PreviousPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A VoidedPurchase resource indicates a purchase that was either canceled/refunded/charged-
    /// back.</summary>
    public class VoidedPurchase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This kind represents a voided purchase object in the androidpublisher service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The time at which the purchase was made, in milliseconds since the epoch (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseTimeMillis")]
        public virtual System.Nullable<long> PurchaseTimeMillis { get; set; } 

        /// <summary>The token which uniquely identifies a one-time purchase or subscription. To uniquely identify
        /// subscription renewals use order_id (available starting from version 3 of the API).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purchaseToken")]
        public virtual string PurchaseToken { get; set; } 

        /// <summary>The time at which the purchase was canceled/refunded/charged-back, in milliseconds since the epoch
        /// (Jan 1, 1970).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voidedTimeMillis")]
        public virtual System.Nullable<long> VoidedTimeMillis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class VoidedPurchasesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual PageInfo PageInfo { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("tokenPagination")]
        public virtual TokenPagination TokenPagination { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("voidedPurchases")]
        public virtual System.Collections.Generic.IList<VoidedPurchase> VoidedPurchases { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
