namespace Apis.Dotnet.Request.Validation.UnitTest.GenericStringComparator
{
    public class StringComparatorDTO
    {
        [Attributes.GenericStringComparator("Ab329_d38#", "The values mustn't be different")]
        public string StringToCompare { get; set; }
    }
}
