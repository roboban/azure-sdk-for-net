// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account schema filter for odata query.
    /// </summary>
    public partial class IntegrationAccountSchemaFilter
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSchemaFilter
        /// class.
        /// </summary>
        public IntegrationAccountSchemaFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSchemaFilter
        /// class.
        /// </summary>
        /// <param name="schemaType">The schema type of integration account
        /// schema. Possible values include: 'NotSpecified', 'Xml'</param>
        public IntegrationAccountSchemaFilter(string schemaType)
        {
            SchemaType = schemaType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the schema type of integration account schema.
        /// Possible values include: 'NotSpecified', 'Xml'
        /// </summary>
        [JsonProperty(PropertyName = "schemaType")]
        public string SchemaType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SchemaType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchemaType");
            }
        }
    }
}