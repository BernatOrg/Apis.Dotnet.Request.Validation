using System.Collections;
using System.Collections.Generic;

namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    public class IntArrayDataGenerator: IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] { null,false},
            new object[] { new int[]{},false},
            new object[] { new int[]{1},true},
            new object[] { new int[]{1,3},true}
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
    
}