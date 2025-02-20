// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> Customer Care Information. </summary>
    public partial class CustomerCareInformation
    {
        /// <summary> Initializes a new instance of <see cref="CustomerCareInformation"/>. </summary>
        public CustomerCareInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomerCareInformation"/>. </summary>
        /// <param name="tollFreeNumber"> Customer support phone number for the customer submitting the Program Brief. Use E164 format. e.g. +18005551212. </param>
        /// <param name="email"> Customer support email address for the customer submitting the Program Brief. </param>
        internal CustomerCareInformation(string tollFreeNumber, string email)
        {
            TollFreeNumber = tollFreeNumber;
            Email = email;
        }

        /// <summary> Customer support phone number for the customer submitting the Program Brief. Use E164 format. e.g. +18005551212. </summary>
        public string TollFreeNumber { get; set; }
        /// <summary> Customer support email address for the customer submitting the Program Brief. </summary>
        public string Email { get; set; }
    }
}
