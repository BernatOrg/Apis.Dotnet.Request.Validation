using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Apis.Dotnet.Request.Validation.Attributes
{
    /// <summary>
    /// Models a Validation about if a spanish fical code has a valid format
    /// </summary>
    public class SpanishFiscalCodeValidator : ValidationAttribute
    {
        #region constants

        private const string VALID_NIF_PATTERN = @"[0-9]{8}[A-Za-z]";
        private const string VALID_NIE_PATTERN = @"[XYZ][0-9]{7}[A-Za-z]";
        private const string VALID_SPANISH_PASSPORT_PATTERN = @"[A-Za-z]{3}[0-9]{6}[A-Za-z]?";

        #endregion

        #region constructor

        /// <summary>
        ///Class constructor
        /// </summary>
        public SpanishFiscalCodeValidator() : base(() => "{0} spanish fiscal code not valid.") { }

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
            if (value is null || !(value is string))
                return false;

            string document = (string)value;

            Regex nifVal = new Regex(VALID_NIF_PATTERN);
            Regex nieVal = new Regex(VALID_NIE_PATTERN);
            Regex passportVal = new Regex(VALID_SPANISH_PASSPORT_PATTERN);
            return nifVal.IsMatch(document) || nieVal.IsMatch(document) || passportVal.IsMatch(document);
        }

        #endregion
    }
}
