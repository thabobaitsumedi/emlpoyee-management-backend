﻿using System.Collections.Generic;

namespace EmployeeManagement.Application.Messages
{
    public class GetAddressTypesQueryResponse
    {
        public GetAddressTypesQueryResponse()
        {
            AddressTypes = new List<AddressTypeResponse>();
        }

        public List<AddressTypeResponse> AddressTypes { get; set; }
    }

    public class AddressTypeResponse
    {
        public int AddressTypeId { get; set; }

        public string AddressDescription { get; set; }
    }
}