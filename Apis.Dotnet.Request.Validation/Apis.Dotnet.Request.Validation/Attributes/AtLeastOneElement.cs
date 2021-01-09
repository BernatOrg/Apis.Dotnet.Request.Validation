using System;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Collections.Generic;


namespace Apis.Dotnet.Request.Validation.Attributes
{
    /// <summary>
    /// Models a Validation to check if collection of elements has at least one element.
    /// </summary>
    public class AtLeastOneElement: ValidationAttribute
    {

        #region constructors

        /// <summary>
        ///Class constructor
        /// </summary>
        public AtLeastOneElement() : base(() => "{0} parameter must has at least one element") { }

        #endregion
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
            if(object.ReferenceEquals(null,value))
                return false;
                
            Type valueType = value.GetType();
            Type expectedType = typeof(IList);

            if (value is IList)
            {
                IList list = (IList)value;
                return list.Count > 0;                
            }
            else if (valueType.IsArray)
            {
                Type elementType = valueType.GetElementType();
                switch(Type.GetTypeCode(elementType))
                {
                    case TypeCode.Boolean:
                    return ((bool[])value).Length > 0;
                    
                    case TypeCode.Int32:
                    return ((int[])value).Length > 0;

                    case TypeCode.Byte:
                    return ((byte[])value).Length > 0;

                    case TypeCode.Decimal:
                    return ((decimal[])value).Length > 0;

                    case TypeCode.Char:
                    return ((char[])value).Length > 0;

                    case TypeCode.String:
                    return ((string[])value).Length > 0;

                    default:
                    return ((object[])value).Length > 0;
                }
                
            }
            return false;
        }
    }
}