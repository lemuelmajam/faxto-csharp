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
    /// InlineResponse20016Data
    /// </summary>
    [DataContract]
    public partial class InlineResponse20016Data :  IEquatable<InlineResponse20016Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20016Data" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="didId">didId.</param>
        /// <param name="didGroupId">didGroupId.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="cityName">cityName.</param>
        /// <param name="areaCode">areaCode.</param>
        /// <param name="number">number.</param>
        /// <param name="type">type.</param>
        /// <param name="trunkId">trunkId.</param>
        public InlineResponse20016Data(int? id = default(int?), int? didId = default(int?), int? didGroupId = default(int?), string countryCode = default(string), string cityName = default(string), string areaCode = default(string), string number = default(string), string type = default(string), int? trunkId = default(int?))
        {
            this.Id = id;
            this.DidId = didId;
            this.DidGroupId = didGroupId;
            this.CountryCode = countryCode;
            this.CityName = cityName;
            this.AreaCode = areaCode;
            this.Number = number;
            this.Type = type;
            this.TrunkId = trunkId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets DidId
        /// </summary>
        [DataMember(Name="did_id", EmitDefaultValue=false)]
        public int? DidId { get; set; }

        /// <summary>
        /// Gets or Sets DidGroupId
        /// </summary>
        [DataMember(Name="did_group_id", EmitDefaultValue=false)]
        public int? DidGroupId { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets CityName
        /// </summary>
        [DataMember(Name="city_name", EmitDefaultValue=false)]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or Sets AreaCode
        /// </summary>
        [DataMember(Name="area_code", EmitDefaultValue=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TrunkId
        /// </summary>
        [DataMember(Name="trunk_id", EmitDefaultValue=false)]
        public int? TrunkId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20016Data {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DidId: ").Append(DidId).Append("\n");
            sb.Append("  DidGroupId: ").Append(DidGroupId).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TrunkId: ").Append(TrunkId).Append("\n");
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
            return this.Equals(input as InlineResponse20016Data);
        }

        /// <summary>
        /// Returns true if InlineResponse20016Data instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20016Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20016Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DidId == input.DidId ||
                    (this.DidId != null &&
                    this.DidId.Equals(input.DidId))
                ) && 
                (
                    this.DidGroupId == input.DidGroupId ||
                    (this.DidGroupId != null &&
                    this.DidGroupId.Equals(input.DidGroupId))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.CityName == input.CityName ||
                    (this.CityName != null &&
                    this.CityName.Equals(input.CityName))
                ) && 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TrunkId == input.TrunkId ||
                    (this.TrunkId != null &&
                    this.TrunkId.Equals(input.TrunkId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DidId != null)
                    hashCode = hashCode * 59 + this.DidId.GetHashCode();
                if (this.DidGroupId != null)
                    hashCode = hashCode * 59 + this.DidGroupId.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.CityName != null)
                    hashCode = hashCode * 59 + this.CityName.GetHashCode();
                if (this.AreaCode != null)
                    hashCode = hashCode * 59 + this.AreaCode.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TrunkId != null)
                    hashCode = hashCode * 59 + this.TrunkId.GetHashCode();
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