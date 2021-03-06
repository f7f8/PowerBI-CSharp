// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A Power BI Report
    /// </summary>
    public partial class Report
    {
        /// <summary>
        /// Initializes a new instance of the Report class.
        /// </summary>
        public Report() { }

        /// <summary>
        /// Initializes a new instance of the Report class.
        /// </summary>
        public Report(string id = default(string), string name = default(string), string webUrl = default(string), string embedUrl = default(string))
        {
            Id = id;
            Name = name;
            WebUrl = webUrl;
            EmbedUrl = embedUrl;
        }

        /// <summary>
        /// The report id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The report name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The report web url
        /// </summary>
        [JsonProperty(PropertyName = "webUrl")]
        public string WebUrl { get; set; }

        /// <summary>
        /// The report embed url
        /// </summary>
        [JsonProperty(PropertyName = "embedUrl")]
        public string EmbedUrl { get; set; }

    }
}
