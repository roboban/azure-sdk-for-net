// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains a sourceId and workbook resource id to link two resources.
    /// </summary>
    public partial class LinkProperties
    {
        /// <summary>
        /// Initializes a new instance of the LinkProperties class.
        /// </summary>
        public LinkProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LinkProperties class.
        /// </summary>
        /// <param name="sourceId">The source Azure resource id</param>
        /// <param name="targetId">The workbook Azure resource id</param>
        /// <param name="category">The category of workbook</param>
        public LinkProperties(string sourceId = default(string), string targetId = default(string), string category = default(string))
        {
            SourceId = sourceId;
            TargetId = targetId;
            Category = category;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source Azure resource id
        /// </summary>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or sets the workbook Azure resource id
        /// </summary>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets the category of workbook
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

    }
}