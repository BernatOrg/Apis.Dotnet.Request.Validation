using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Apis.Dotnet.Request.Validation.Attributes
{
    /// <summary>
    /// Models a Validation about at least one property has a not null value
    /// </summary>    
    public class MinOneValidValue : ValidationAttribute
    {

        #region fields

        private string[] paramsList;

        #endregion

        #region constructors

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="list">List of property names to check if all of their values at least one is valid</param>
        /// <param name="valueToCompare">String value to compare</param>
        public MinOneValidValue(params string[] list) : base(() => "{0} parameter mustn't be null.")
        {
            this.paramsList = list;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="list">List of property names to check if all of their values at least one is valid</param>
        /// <param name="valueToCompare">String value to compare</param>
        public MinOneValidValue(string errorMessage, params string[] list) : base(() => errorMessage)
        {
            this.paramsList = list;
        }

        #endregion

        #region methods

        //
        // Summary:
        //     Determines whether the specified value of the object is valid.
        //
        // Parameters:
        //   value:
        //     The value of the object to validate.
        //
        // Returns:
        //     true if the specified value is valid; otherwise, false.
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var instance = validationContext.ObjectInstance;
            List<PropertyInfo> propertyList =
                    instance.GetType()
                    .GetProperties().
                    Where(
                        p =>
                            this.paramsList.Contains(p.Name) || validationContext.MemberName.Equals(p.Name)
                         )
                    .ToList();


            foreach (PropertyInfo p in propertyList)
            {
                var proprtyvalue = p.GetValue(instance, null);
                if (!(proprtyvalue is null))
                {
                    switch (Type.GetTypeCode(p.PropertyType))
                    {
                        case TypeCode.String:
                            if (!String.IsNullOrEmpty(proprtyvalue.ToString())) { return ValidationResult.Success; }
                            break;

                        case TypeCode.DateTime:
                            if ((DateTime)proprtyvalue > DateTime.MinValue) { return ValidationResult.Success; }
                            break;

                        case TypeCode.Int32:
                            if ((int)proprtyvalue > 0) { return ValidationResult.Success; }
                            break;

                    }
                }
            }
            return new ValidationResult(ErrorMessage);
        }

        #endregion
    }
}
