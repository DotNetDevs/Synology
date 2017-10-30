using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Synology.Utilities
{
    /// <summary>
    /// FormParameter manager used to generate a <seealso cref="MultipartFormDataContent"/> instance with formatted parameters
    /// </summary>
    class FormParameterManager : IDisposable
    {
        internal MultipartFormDataContent MultipartContent { get; }

        public FormParameterManager(IEnumerable<FormParameter> parameters)
        {
            MultipartContent = new MultipartFormDataContent();

            foreach (var parameter in parameters)
            {
	            if (parameter is FileFormDataParameter dataParameter)
                {
	                var fileParameter = dataParameter;
                    var contentData = new ByteArrayContent(fileParameter.FileData);

                    // To conform to Synology API documentation, remove Content-Disposition header
                    contentData.Headers.Remove("Content-Disposition");
                    // To conform to Synology API documentation, format Content-Disposition header in the form : 
                    // Content-Disposition: form-data; name="parameterName"; filename="filename"
                    // The .Net standard implementation does not contain double quotes surrounding the parameter name and the filename is encoded with utf8'' pattern.
                    contentData.Headers.TryAddWithoutValidation("Content-Disposition", $"form-data; name=\"{fileParameter.Name}\"; filename=\"{fileParameter.Value}\"");
                    // To conform to Synology API documentation, set the content-type to application/octet-stream
                    contentData.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    // Add the ByteArrayContent object to the multipart data content
                    MultipartContent.Add(contentData);
                }
                else
                {
                    var contentData = new StringContent(parameter.Value);
                    // To conform to Synology API documentation, remove the Content-Type header
                    contentData.Headers.Remove("Content-Type");
                    // To conform to Synology API documentation, remove Content-Disposition header
                    contentData.Headers.Remove("Content-Disposition");
                    // To conform to Synology API documentation, format Content-Disposition header in the form : 
                    // Content-Disposition: form-data; name="parameterName"
                    // The .Net standard implementation does not contain double quotes surrounding the parameter name.
                    contentData.Headers.TryAddWithoutValidation("Content-Disposition", $"form-data; name=\"{parameter.Name}\"");

                    // Add the StringContent object to the multipart data content
                    MultipartContent.Add(contentData);
                }
            }
        }

        /// <summary>
        /// Returns the MultipartFormDataContent object as byte array
        /// </summary>
        /// <returns></returns>
        public async Task<byte[]> ToByteArrayAsync() => await MultipartContent.ReadAsByteArrayAsync();

        public void Dispose() => MultipartContent.Dispose();
    }
}
