using System.Collections.Generic;


namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    public class ClassWithListDTO
    {
        [Attributes.AtLeastOneElement]
        public List<string> ListElement { get; set; }
    }
}