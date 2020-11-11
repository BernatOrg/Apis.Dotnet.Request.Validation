using System;
using System.Collections.Generic;
using System.Collections;

namespace Apis.Dotnet.Request.Validation.UnitTest.MinOneValue
{
    public class InvalidValuesGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> data = new List<object[]>
        {
            new object[] {null,0, DateTime.MinValue,null,false, "Null parameters" },
            new object[] {String.Empty,0, DateTime.MinValue,null,false, "Null parameters" },
            new object[] {String.Empty, 0, DateTime.MinValue, String.Empty, false, "Null parameters" },
            new object[] {"Cool", 1, DateTime.MinValue, null, true, "" },
            new object[] {null, 1, DateTime.MinValue, null, true, "" },
            new object[] {null, 0, DateTime.Now, null, true, "" },
            new object[] {"Cool", 2, DateTime.Now, "Cool", true, "" },
        };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
