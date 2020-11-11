using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Apis.Dotnet.Request.Validation.UnitTest.MinOneValue
{
    public class UnitTest
    {
        [Theory]
        [ClassData(typeof(InvalidValuesGenerator))]
        [Trait("Validation", "String Comparer UnitTest")]
        public void Invalid_String_Validation_Cases(string prop1, int prop2, DateTime prop3, string prop4, bool expectedResult, string expectedMessage)
        {
            //Arrange
            MinOneValueDTO request = new MinOneValueDTO() { Prop1 = prop1, Prop2 = prop2, Prop3 = prop3, Prop4 = prop4 };


            //// Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

            ////Assert

            Assert.Equal(expectedResult, actual);
            if (!actual)
            {
                var msg = validationResults[0];
                Assert.Contains(expectedMessage, msg.ErrorMessage);
            }
        }



    }
}
