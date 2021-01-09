using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Apis.Dotnet.Request.Validation.UnitTest.OneElement
{
    
    public class UnitTest
    {

        [Theory]
        [ClassData(typeof(IntArrayDataGenerator))]
        [Trait("Utils", "AtLeastOneElement UnitTest")]
         public void Int_Array_Validation_Cases(int[] intArray, bool expectedResult)
         {
             //Arrange
             ClassWithIntArrayDTO request = new ClassWithIntArrayDTO() {IntArrayElement = intArray};

             //Act
             var validationResults = new List<ValidationResult>();
             bool actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

             //Assert
             Assert.Equal(actual, expectedResult);
         }

         [Theory]
         [ClassData(typeof(ObjectArrayDataGenerator))]
         [Trait("Utils", "AtLeastOneElement UnitTest")]
         public void Object_Array_Validation_Cases(object[] objArray, bool expectedResult)
         {
             //Arrange
             ClassWithObjectArrayDTO request = new ClassWithObjectArrayDTO() {ObjectArrayElement = objArray};

             //Act
             var validationResults = new List<ValidationResult>();
             bool actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

             //Assert
             Assert.Equal(actual, expectedResult);
         }

         [Theory]
         [ClassData(typeof(ListArrayDataGenerator))]
         [Trait("Utils", "AtLeastOneElement UnitTest")]
         public void List_Validation_Cases(List<string> list, bool expectedResult)
         {
             //Arrange
             ClassWithListDTO request = new ClassWithListDTO() {ListElement = list};

             //Act
             var validationResults = new List<ValidationResult>();
             bool actual = Validator.TryValidateObject(request, new ValidationContext(request), validationResults, true);

             //Assert
             Assert.Equal(expectedResult,actual);
             
         }
        
    }
}