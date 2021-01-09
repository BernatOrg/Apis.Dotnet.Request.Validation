namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    public class ClassWithObjectArrayDTO
    {
        [Attributes.AtLeastOneElement]
        public object[] ObjectArrayElement { get; set; }
    }
}