/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
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

namespace Square.Connect.Model
{
    /// <summary>
    /// V1Page
    /// </summary>
    [DataContract]
    public partial class V1Page :  IEquatable<V1Page>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Page" /> class.
        /// </summary>
        /// <param name="Id">The page&#39;s unique identifier..</param>
        /// <param name="Name">The page&#39;s name, if any..</param>
        /// <param name="PageIndex">The page&#39;s position in the merchant&#39;s list of pages. Always an integer between 0 and 4, inclusive..</param>
        /// <param name="Cells">The cells included on the page..</param>
        public V1Page(string Id = default(string), string Name = default(string), int? PageIndex = default(int?), List<V1PageCell> Cells = default(List<V1PageCell>))
        {
            this.Id = Id;
            this.Name = Name;
            this.PageIndex = PageIndex;
            this.Cells = Cells;
        }
        
        /// <summary>
        /// The page&#39;s unique identifier.
        /// </summary>
        /// <value>The page&#39;s unique identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The page&#39;s name, if any.
        /// </summary>
        /// <value>The page&#39;s name, if any.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The page&#39;s position in the merchant&#39;s list of pages. Always an integer between 0 and 4, inclusive.
        /// </summary>
        /// <value>The page&#39;s position in the merchant&#39;s list of pages. Always an integer between 0 and 4, inclusive.</value>
        [DataMember(Name="page_index", EmitDefaultValue=false)]
        public int? PageIndex { get; set; }
        /// <summary>
        /// The cells included on the page.
        /// </summary>
        /// <value>The cells included on the page.</value>
        [DataMember(Name="cells", EmitDefaultValue=false)]
        public List<V1PageCell> Cells { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Page {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1Page);
        }

        /// <summary>
        /// Returns true if V1Page instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Page to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Page other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.Cells == other.Cells ||
                    this.Cells != null &&
                    this.Cells.SequenceEqual(other.Cells)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.Cells != null)
                    hash = hash * 59 + this.Cells.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}