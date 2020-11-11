using System;

namespace Apis.Dotnet.Request.Validation.UnitTest.NullDateTime
{
    public class DateTestDTO
    {
        [Attributes.NullDateTime]
        public DateTime DateToTest { get; set; }

    }
}
