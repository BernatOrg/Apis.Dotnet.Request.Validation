using System.Collections;
using System.Collections.Generic;

namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    public class ObjectArrayDataGenerator: IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
            new object[] { null,false},
            new object[] { new object[]{},false},
            new object[] { new object[]{new object()},true},
            new object[] { new object[]{new object(),new object()},true}
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

}