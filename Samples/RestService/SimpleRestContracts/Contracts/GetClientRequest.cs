﻿using System;
using System.Runtime.Serialization;

namespace SimpleRestContracts.Contracts
{
    [DataContract]
    public sealed class GetClientRequest
    {
        [DataMember]
        public Guid Id { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}", Id);
        }
    }
}
