using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;
namespace Apis.Dotnet.Request.Validation.UnitTest.GenericStringComparator
{
    public class UnitTest
    {
        [Theory]
        [ClassData(typeof(InvalidStringGenerator))]
        [Trait("Validation", "String Comparer UnitTest")]
        public void Invalid_String_Validation_Cases(string stringToCompare, string expectedMessage)
        {
            //Arrange
            StringComparatorDTO request = new StringComparatorDTO() { StringToCompare = stringToCompare };

            // Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

            //Assert
            Assert.False(actual);
            Assert.True(validationResults.Count == 1);
            var msg = validationResults[0];
            Assert.Equal(expectedMessage, msg.ErrorMessage);

        }


        [Theory]
        [ClassData(typeof(ValidStringGenerator))]
        [Trait("Validation", "String Comparer UnitTest")]
        public void Valid_String_Validation_Cases(string stringToCompare)
        {
            //Arrange
            StringComparatorDTO request = new StringComparatorDTO() { StringToCompare = stringToCompare };

            // Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

            //Assert
            Assert.True(actual);
            Assert.True(!validationResults.Any());

        }
    }
}
