using System;
using System.ComponentModel.DataAnnotations;

namespace Apis.Dotnet.Request.Validation.Attributes
{
    /// <summary>
    /// Models a Validation about equality of two strings
    /// </summary>
    public class GenericStringComparator : ValidationAttribute
    {
        #region fields

        private string stringToCompare;

        #endregion

        #region constructors

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="valueToCompare">String value to compare</param>
        public GenericStringComparator(string valueToCompare) : base(() => "{0} hasn't the correct value")
        {
            this.stringToCompare = valueToCompare;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="valueToCompare">String value to compare</param>
        /// <param name="errorMessage">Message to display</param>
        public GenericStringComparator(string valueToCompare, string errorMessage) : base(() => errorMessage)
        {
            this.stringToCompare = valueToCompare;
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
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            string str = value as string;
            if (str != null)
            {
                return String.Compare(this.stringToCompare, str,
                                      StringComparison.OrdinalIgnoreCase) == 0;
            }
            return false;
        }

        #endregion
    }
}
