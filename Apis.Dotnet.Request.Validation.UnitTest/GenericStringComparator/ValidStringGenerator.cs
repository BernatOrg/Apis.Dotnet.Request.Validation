using System.Collections;
using System.Collections.Generic;

namespace Apis.Dotnet.Request.Validation.UnitTest.GenericStringComparator
{
    public class ValidStringGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
    {
        new object[] {"Ab329_d38#"},
        new object[] {"aB329_D38#"}
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
