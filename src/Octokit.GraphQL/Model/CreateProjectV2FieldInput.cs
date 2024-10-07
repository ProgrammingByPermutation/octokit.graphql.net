namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateProjectV2Field
    /// </summary>
    public class CreateProjectV2FieldInput
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The ID of the Project to create the field in.
        /// </summary>
        public ID ProjectId { get; set; }

        /// <summary>
        /// The data type of the field.
        /// </summary>
        public ProjectV2CustomFieldType DataType { get; set; }

        /// <summary>
        /// The name of the field.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Options for a single select field. At least one value is required if data_type is SINGLE_SELECT
        /// </summary>
        public IEnumerable<ProjectV2SingleSelectFieldOptionInput> SingleSelectOptions { get; set; }
    }
}