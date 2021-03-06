// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Part of MultiTenantDiagnosticSettings. Specifies the settings for a
    /// particular metric.
    /// </summary>
    public partial class MetricSettings
    {
        /// <summary>
        /// Initializes a new instance of the MetricSettings class.
        /// </summary>
        public MetricSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSettings class.
        /// </summary>
        /// <param name="enabled">a value indicating whether this category is
        /// enabled.</param>
        /// <param name="timeGrain">the timegrain of the metric in ISO8601
        /// format.</param>
        /// <param name="category">Name of a Diagnostic Metric category for a
        /// resource type this setting is applied to. To obtain the list of
        /// Diagnostic metric categories for a resource, first perform a GET
        /// diagnostic settings operation.</param>
        /// <param name="retentionPolicy">the retention policy for this
        /// category.</param>
        public MetricSettings(bool enabled, System.TimeSpan? timeGrain = default(System.TimeSpan?), string category = default(string), RetentionPolicy retentionPolicy = default(RetentionPolicy))
        {
            TimeGrain = timeGrain;
            Category = category;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the timegrain of the metric in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public System.TimeSpan? TimeGrain { get; set; }

        /// <summary>
        /// Gets or sets name of a Diagnostic Metric category for a resource
        /// type this setting is applied to. To obtain the list of Diagnostic
        /// metric categories for a resource, first perform a GET diagnostic
        /// settings operation.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this category is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for this category.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionPolicy != null)
            {
                RetentionPolicy.Validate();
            }
        }
    }
}
