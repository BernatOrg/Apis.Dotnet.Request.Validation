using System;
using System.Collections;
using System.Collections.Generic;

namespace Apis.Dotnet.Request.Validation.UnitTest.FiscalCode
{
    public class FiscalCodeDataGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> data = new List<object[]>
    {
        new object[] { null,false},
        new object[] { String.Empty,false},
        new object[] { "4",false},
        new object[] { "3dss",false},
        new object[] { "a32.2",false},
        new object[] { "54362690A",true},
        new object[] { "X1234567L", true},
        new object[] { "X1234567", false},
        new object[] { "1234567L", false},
        new object[] { "X123467L", false},
    };

        public IEnumerator<object[]> GetEnumerator() => data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
