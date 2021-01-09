namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    public class ClassWithIntArrayDTO
    {
        [Attributes.AtLeastOneElement]
        public int[] IntArrayElement { get; set; }
    }
}