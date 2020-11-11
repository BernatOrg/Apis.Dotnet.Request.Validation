using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Xunit;

namespace Apis.Dotnet.Request.Validation.UnitTest.NullDateTime
{
    public class UnitTest
    {
        [Theory]
        [ClassData(typeof(InvalidStartDateDataGenerator))]
        [Trait("Validation", "StartDate UnitTest")]
        public void Invalid_Date_Validation_Cases(DateTime dateToTest, string expectedMessage)
        {
            //Arrange
            DateTestDTO request = new DateTestDTO() { DateToTest = dateToTest };

            // Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

            //Assert
            Assert.False(actual);
            Assert.True(validationResults.Count == 1);
            var msg = validationResults[0];
            Assert.Contains(expectedMessage, msg.ErrorMessage);

        }

        [Theory]
        [ClassData(typeof(ValidStartDateDataGenerator))]
        [Trait("Validation", "StartDate UnitTest")]
        public void Valid_Date_Validation_Cases(DateTime dateToTest)
        {
            //Arrange
            DateTestDTO request = new DateTestDTO() { DateToTest = dateToTest };

            // Act
            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

            //Assert
            Assert.True(actual);
            Assert.True(!validationResults.Any());

        }
    }
}
