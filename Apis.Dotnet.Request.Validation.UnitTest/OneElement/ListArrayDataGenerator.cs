using System.Collections;
using System.Collections.Generic;

namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    public class ListArrayDataGenerator: IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
           new object[] { null,false},
           new object[] { new List<string>(),false},
           new object[] { new List<string> { "One" },true},
           new object[] { new List<string> { "One", "Two", "Three" },true}
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
    
}