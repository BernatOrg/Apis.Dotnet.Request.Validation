using System;

namespace Apis.Dotnet.Request.Validation.UnitTest.MinOneValue
{
    public class MinOneValueDTO
    {

        private string[] arr = { nameof(Prop1), nameof(Prop2), nameof(Prop3), nameof(Prop4) };

        [Attributes.MinOneValidValue("Null parameters", nameof(Prop2), nameof(Prop3), nameof(Prop4))]
        public string Prop1 { get; set; }

        public int Prop2 { get; set; }

        public DateTime Prop3 { get; set; }

        public string Prop4 { get; set; }
    }
}
