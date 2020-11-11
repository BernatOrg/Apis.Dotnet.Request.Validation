using System;
using System.Collections.Generic;
using System.Text;

namespace Apis.Dotnet.Request.Validation.UnitTest.FiscalCode
{
    public class FiscalCodeDTO
    {

        [Attributes.SpanishFiscalCodeValidator]
        public string FiscalCode { get; set; }

    }
}
