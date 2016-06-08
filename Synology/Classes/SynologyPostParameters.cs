using Synology.Utilities;

namespace Synology.Classes
{
    /// <summary>
    /// Parameters used for post requests
    /// </summary>
    public class SynologyPostParameters
    {
        /// <summary>
        /// Api method to use
        /// </summary>
        public string Method { get; set; }
        /// <summary>
        /// Version of the method / api to use
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// Parameters to add to the request (as post data)
        /// TODO : Add the support for mixed get / post parameters
        /// </summary>
        public FormParameter[] Additional { get; set; }

        public SynologyPostParameters()
        {
            // Default version to 1
            Version = 1;
        }
    }
}
