using System;
using System.ComponentModel.DataAnnotations;

namespace Apis.Dotnet.Request.Validation.Attributes
{
    /// <summary>
    /// Models a Validation about if a datetime value is null
    /// </summary>
    public class NullDateTime : ValidationAttribute
    {
        #region constructor

        /// <summary>
        ///Class constructor
        /// </summary>
        public NullDateTime() : base(() => "{0} parameter mustn't be null.") { }

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
            DateTime dat = (DateTime)value;
            return !dat.Equals(DateTime.MinValue);
        }

        #endregion

    }
}
