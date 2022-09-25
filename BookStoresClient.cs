

namespace BookStoresService
    {
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class BookStoresClient
        {
        private string _baseUrl = "";
        private System.Net.Http.HttpClient _httpClient;
        private System.Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public BookStoresClient(string baseUrl, System.Net.Http.HttpClient httpClient)
            {
            BaseUrl = baseUrl;
            _httpClient = httpClient;
            _settings = new System.Lazy<Newtonsoft.Json.JsonSerializerSettings>(CreateSerializerSettings);
            }

        private Newtonsoft.Json.JsonSerializerSettings CreateSerializerSettings()
            {
            var settings = new Newtonsoft.Json.JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
            }

        public string BaseUrl
            {
            get { return _baseUrl; }
            set { _baseUrl = value; }
            }

        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        partial void UpdateJsonSerializerSettings(Newtonsoft.Json.JsonSerializerSettings settings);

        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url);
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, System.Text.StringBuilder urlBuilder);
        partial void ProcessResponse(System.Net.Http.HttpClient client, System.Net.Http.HttpResponseMessage response);

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Author>> AuthorsAsync()
            {
            return AuthorsAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Author>> AuthorsAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/Authors");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Author>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Publisher>> GetPublishersAsync()
            {
            return GetPublishersAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Publisher>> GetPublishersAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/GetPublishers");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Publisher>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Publisher>> PublishersAsync()
            {
            return PublishersAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<Publisher>> PublishersAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<Publisher>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<Publisher> GetPublisherDetailsAsync(int id)
            {
            return GetPublisherDetailsAsync(id, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<Publisher> GetPublisherDetailsAsync(int id, System.Threading.CancellationToken cancellationToken)
            {
            if (id == null)
                throw new System.ArgumentNullException("id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/GetPublisherDetails/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<Publisher>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<Publisher> PostPublisherDetailsAsync()
            {
            return PostPublisherDetailsAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<Publisher> PostPublisherDetailsAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/PostPublisherDetails");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<Publisher>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<Publisher> GetPublisherAsync(int id)
            {
            return GetPublisherAsync(id, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<Publisher> GetPublisherAsync(int id, System.Threading.CancellationToken cancellationToken)
            {
            if (id == null)
                throw new System.ArgumentNullException("id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/GetPublisher/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<Publisher>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<Publisher> CreatePublisherAsync(Publisher body)
            {
            return CreatePublisherAsync(body, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<Publisher> CreatePublisherAsync(Publisher body, System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/CreatePublisher");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<Publisher>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task UpdatePublisherAsync(int id, Publisher body)
            {
            return UpdatePublisherAsync(id, body, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task UpdatePublisherAsync(int id, Publisher body, System.Threading.CancellationToken cancellationToken)
            {
            if (id == null)
                throw new System.ArgumentNullException("id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/UpdatePublisher/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("PUT");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            return;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<Publisher> DeletePublisherAsync(int id)
            {
            return DeletePublisherAsync(id, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<Publisher> DeletePublisherAsync(int id, System.Threading.CancellationToken cancellationToken)
            {
            if (id == null)
                throw new System.ArgumentNullException("id");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Publishers/DeletePublisher/{id}");
            urlBuilder_.Replace("{id}", System.Uri.EscapeDataString(ConvertToString(id, System.Globalization.CultureInfo.InvariantCulture)));

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("DELETE");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<Publisher>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<User>> UsersAsync()
            {
            return UsersAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<User>> UsersAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Users");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<User>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<User> GetUserAsync()
            {
            return GetUserAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<User> GetUserAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Users/GetUser");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<User>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<UserWithToken> LoginAsync(User body)
            {
            return LoginAsync(body, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<UserWithToken> LoginAsync(User body, System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Users/Login");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<UserWithToken>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<UserWithToken> RefreshTokenAsync(RefreshRequest body)
            {
            return RefreshTokenAsync(body, System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<UserWithToken> RefreshTokenAsync(RefreshRequest body, System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/api/Users/RefreshToken");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    var json_ = Newtonsoft.Json.JsonConvert.SerializeObject(body, _settings.Value);
                    var content_ = new System.Net.Http.StringContent(json_);
                    content_.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json-patch+json");
                    request_.Content = content_;
                    request_.Method = new System.Net.Http.HttpMethod("POST");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<UserWithToken>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.ICollection<WeatherForecast>> WeatherForecastAsync()
            {
            return WeatherForecastAsync(System.Threading.CancellationToken.None);
            }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async System.Threading.Tasks.Task<System.Collections.Generic.ICollection<WeatherForecast>> WeatherForecastAsync(System.Threading.CancellationToken cancellationToken)
            {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/WeatherForecast");

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
                {
                using (var request_ = new System.Net.Http.HttpRequestMessage())
                    {
                    request_.Method = new System.Net.Http.HttpMethod("GET");
                    request_.Headers.Accept.Add(System.Net.Http.Headers.MediaTypeWithQualityHeaderValue.Parse("text/plain"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new System.Uri(url_, System.UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, System.Net.Http.HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                        {
                        var headers_ = System.Linq.Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                            {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                            }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                            {
                            var objectResponse_ = await ReadObjectResponseAsync<System.Collections.Generic.ICollection<WeatherForecast>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                                }
                            return objectResponse_.Object;
                            }
                        else
                            {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                            }
                        }
                    finally
                        {
                        if (disposeResponse_)
                            response_.Dispose();
                        }
                    }
                }
            finally
                {
                if (disposeClient_)
                    client_.Dispose();
                }
            }

        protected struct ObjectResponseResult<T>
            {
            public ObjectResponseResult(T responseObject, string responseText)
                {
                this.Object = responseObject;
                this.Text = responseText;
                }

            public T Object { get; }

            public string Text { get; }
            }

        public bool ReadResponseAsString { get; set; }

        protected virtual async System.Threading.Tasks.Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(System.Net.Http.HttpResponseMessage response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Threading.CancellationToken cancellationToken)
            {
            if (response == null || response.Content == null)
                {
                return new ObjectResponseResult<T>(default(T), string.Empty);
                }

            if (ReadResponseAsString)
                {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                    {
                    var typedBody = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                    }
                catch (Newtonsoft.Json.JsonException exception)
                    {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                    }
                }
            else
                {
                try
                    {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new System.IO.StreamReader(responseStream))
                    using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                        {
                        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                        }
                    }
                catch (Newtonsoft.Json.JsonException exception)
                    {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                    }
                }
            }

        private string ConvertToString(object value, System.Globalization.CultureInfo cultureInfo)
            {
            if (value == null)
                {
                return "";
                }

            if (value is System.Enum)
                {
                var name = System.Enum.GetName(value.GetType(), value);
                if (name != null)
                    {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                        {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                            {
                            return attribute.Value != null ? attribute.Value : name;
                            }
                        }

                    var converted = System.Convert.ToString(System.Convert.ChangeType(value, System.Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted == null ? string.Empty : converted;
                    }
                }
            else if (value is bool)
                {
                return System.Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
                }
            else if (value is byte[])
                {
                return System.Convert.ToBase64String((byte[])value);
                }
            else if (value.GetType().IsArray)
                {
                var array = System.Linq.Enumerable.OfType<object>((System.Array)value);
                return string.Join(",", System.Linq.Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
                }

            var result = System.Convert.ToString(value, cultureInfo);
            return result == null ? "" : result;
            }
        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class Author
        {
        [Newtonsoft.Json.JsonProperty("authorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AuthorId { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }

        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [Newtonsoft.Json.JsonProperty("emailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("bookAuthors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BookAuthor> BookAuthors { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class Book
        {
        [Newtonsoft.Json.JsonProperty("bookId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BookId { get; set; }

        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Title { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("pubId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PubId { get; set; }

        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price { get; set; }

        [Newtonsoft.Json.JsonProperty("advance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Advance { get; set; }

        [Newtonsoft.Json.JsonProperty("royalty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Royalty { get; set; }

        [Newtonsoft.Json.JsonProperty("ytdSales", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? YtdSales { get; set; }

        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [Newtonsoft.Json.JsonProperty("publishedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset PublishedDate { get; set; }

        [Newtonsoft.Json.JsonProperty("pub", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Publisher Pub { get; set; }

        [Newtonsoft.Json.JsonProperty("bookAuthors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BookAuthor> BookAuthors { get; set; }

        [Newtonsoft.Json.JsonProperty("sales", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sale> Sales { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class BookAuthor
        {
        [Newtonsoft.Json.JsonProperty("authorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AuthorId { get; set; }

        [Newtonsoft.Json.JsonProperty("bookId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BookId { get; set; }

        [Newtonsoft.Json.JsonProperty("authorOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AuthorOrder { get; set; }

        [Newtonsoft.Json.JsonProperty("royalityPercentage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RoyalityPercentage { get; set; }

        [Newtonsoft.Json.JsonProperty("author", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Author Author { get; set; }

        [Newtonsoft.Json.JsonProperty("book", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Book Book { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class Publisher
        {
        [Newtonsoft.Json.JsonProperty("pubId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PubId { get; set; }

        [Newtonsoft.Json.JsonProperty("publisherName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PublisherName { get; set; }

        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country { get; set; }

        [Newtonsoft.Json.JsonProperty("books", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Book> Books { get; set; }

        [Newtonsoft.Json.JsonProperty("users", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<User> Users { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class RefreshRequest
        {
        [Newtonsoft.Json.JsonProperty("accessToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        [Newtonsoft.Json.JsonProperty("refreshToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class RefreshToken
        {
        [Newtonsoft.Json.JsonProperty("tokenId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TokenId { get; set; }

        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }

        [Newtonsoft.Json.JsonProperty("expiryDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ExpiryDate { get; set; }

        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User User { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class Role
        {
        [Newtonsoft.Json.JsonProperty("roleId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoleId { get; set; }

        [Newtonsoft.Json.JsonProperty("roleDesc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoleDesc { get; set; }

        [Newtonsoft.Json.JsonProperty("users", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<User> Users { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class Sale
        {
        [Newtonsoft.Json.JsonProperty("saleId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SaleId { get; set; }

        [Newtonsoft.Json.JsonProperty("storeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        [Newtonsoft.Json.JsonProperty("orderNum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrderNum { get; set; }

        [Newtonsoft.Json.JsonProperty("orderDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset OrderDate { get; set; }

        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Quantity { get; set; }

        [Newtonsoft.Json.JsonProperty("payTerms", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PayTerms { get; set; }

        [Newtonsoft.Json.JsonProperty("bookId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int BookId { get; set; }

        [Newtonsoft.Json.JsonProperty("book", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Book Book { get; set; }

        [Newtonsoft.Json.JsonProperty("store", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Store Store { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class Store
        {
        [Newtonsoft.Json.JsonProperty("storeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StoreId { get; set; }

        [Newtonsoft.Json.JsonProperty("storeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StoreName { get; set; }

        [Newtonsoft.Json.JsonProperty("storeAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StoreAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }

        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }

        [Newtonsoft.Json.JsonProperty("zip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zip { get; set; }

        [Newtonsoft.Json.JsonProperty("sales", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Sale> Sales { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class User
        {
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("emailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password { get; set; }

        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Source { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("middleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("roleId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoleId { get; set; }

        [Newtonsoft.Json.JsonProperty("pubId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PubId { get; set; }

        [Newtonsoft.Json.JsonProperty("hireDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? HireDate { get; set; }

        [Newtonsoft.Json.JsonProperty("pub", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Publisher Pub { get; set; }

        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Role Role { get; set; }

        [Newtonsoft.Json.JsonProperty("refreshTokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RefreshToken> RefreshTokens { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class UserWithToken
        {
        [Newtonsoft.Json.JsonProperty("userId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int UserId { get; set; }

        [Newtonsoft.Json.JsonProperty("emailAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password { get; set; }

        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Source { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("middleName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("roleId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RoleId { get; set; }

        [Newtonsoft.Json.JsonProperty("pubId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PubId { get; set; }

        [Newtonsoft.Json.JsonProperty("hireDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? HireDate { get; set; }

        [Newtonsoft.Json.JsonProperty("pub", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Publisher Pub { get; set; }

        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Role Role { get; set; }

        [Newtonsoft.Json.JsonProperty("refreshTokens", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RefreshToken> RefreshTokens { get; set; }

        [Newtonsoft.Json.JsonProperty("token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Token { get; set; }

        [Newtonsoft.Json.JsonProperty("accessToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        [Newtonsoft.Json.JsonProperty("refreshToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class WeatherForecast
        {
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset Date { get; set; }

        [Newtonsoft.Json.JsonProperty("temperatureC", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TemperatureC { get; set; }

        [Newtonsoft.Json.JsonProperty("temperatureF", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TemperatureF { get; set; }

        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        }



    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ApiException : System.Exception
        {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
            {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
            }

        public override string ToString()
            {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
            }
        }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.17.0.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
        {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
            {
            Result = result;
            }
        }

    }

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603
