// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The contact information for the vault certificates.
    /// </summary>
    public partial class Contact
    {
        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Initializes a new instance of the Contact class.
        /// </summary>
        /// <param name="emailAddress">Email addresss.</param>
        /// <param name="name">Name.</param>
        /// <param name="phone">Phone number.</param>
        public Contact(string emailAddress = default(string), string name = default(string), string phone = default(string))
        {
            EmailAddress = emailAddress;
            Name = name;
            Phone = phone;
        }

        /// <summary>
        /// Gets or sets email addresss.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

    }
}

