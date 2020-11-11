using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Apis.Dotnet.Request.Validation.UnitTest.FiscalCode
{
    public class UnitTest
    {
        [Theory]
        [ClassData(typeof(FiscalCodeDataGenerator))]
        [Trait("Utils", "FiscalCodeValidator UnitTest")]
        public void FiscalCode_Validation_Cases(string fiscalCodeToValidate, bool expectedResult)
        {
            //Arrange
            FiscalCodeDTO request = new FiscalCodeDTO() { FiscalCode = fiscalCodeToValidate };

            // Act
            var validationResults = new List<ValidationResult>();
            bool actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

            //Assert
            Assert.Equal(actual, expectedResult);

        }

    }
}
