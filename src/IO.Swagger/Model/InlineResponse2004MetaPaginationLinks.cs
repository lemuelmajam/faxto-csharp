/* 
 * Fax.to REST API client for C#
 *
 * This is Fax.to REST API client for C#.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: inquiries@fax.to
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The pagination links
    /// </summary>
    [DataContract]
    public partial class InlineResponse2004MetaPaginationLinks :  IEquatable<InlineResponse2004MetaPaginationLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2004MetaPaginationLinks" /> class.
        /// </summary>
        /// <param name="previous">previous.</param>
        /// <param name="next">next.</param>
        public InlineResponse2004MetaPaginationLinks(string previous = default(string), string next = default(string))
        {
            this.Previous = previous;
            this.Next = next;
        }
        
        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name="previous", EmitDefaultValue=false)]
        public string Previous { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2004MetaPaginationLinks {\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2004MetaPaginationLinks);
        }

        /// <summary>
        /// Returns true if InlineResponse2004MetaPaginationLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2004MetaPaginationLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2004MetaPaginationLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Previous == input.Previous ||
                    (this.Previous != null &&
                    this.Previous.Equals(input.Previous))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Previous != null)
                    hashCode = hashCode * 59 + this.Previous.GetHashCode();
                if (this.Next != null)
                    hashCode = hashCode * 59 + this.Next.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}