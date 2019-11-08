﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoMobile.Api.Domain.DTOs
{
    public class AddressDto
    {
        public string ZipCode { get; set; }

        public string Number { get; set; }

        public string Street { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Country { get; set; }
    }
}
