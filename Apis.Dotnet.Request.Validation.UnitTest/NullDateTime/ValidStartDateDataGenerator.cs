using System;
using System.Collections;
using System.Collections.Generic;

namespace Apis.Dotnet.Request.Validation.UnitTest.NullDateTime
{
    public class ValidStartDateDataGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> data = new List<object[]>
    {
        new object[] { DateTime.MaxValue},
        new object[] { new DateTime(2019, 1, 1, 9, 0, 0) },
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
