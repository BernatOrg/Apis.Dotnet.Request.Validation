using System;
using System.Collections.Generic;
using System.Collections;

namespace Apis.Dotnet.Request.Validation.UnitTest.NullDateTime
{
    public class InvalidStartDateDataGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> data = new List<object[]>
    {
        new object[] { DateTime.MinValue, "parameter mustn't be null." },
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
