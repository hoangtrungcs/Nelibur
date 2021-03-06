﻿using System;
using System.Runtime.Serialization;

namespace SimpleRestContracts.Contracts
{
    [DataContract]
    public sealed class CreateClientRequest
    {
        [DataMember]
        public string Email { get; set; }

        public override string ToString()
        {
            return string.Format("Email: {0}", Email);
        }
    }
}
