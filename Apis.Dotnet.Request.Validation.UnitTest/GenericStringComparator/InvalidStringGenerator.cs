using System;
using System.Collections.Generic;
using System.Collections;

namespace Apis.Dotnet.Request.Validation.UnitTest.GenericStringComparator
{
    public class InvalidStringGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> data = new List<object[]>
        {
        new object[] {null,"The values mustn't be different"},
        new object[] {String.Empty,"The values mustn't be different"},
        new object[] {"ABC", "The values mustn't be different" }
        };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
