using System;

namespace ShaBoo.Utility
{
    public static class SecUtility
    {
        public static void CheckParameter(ref string param, bool checkForNull, bool checkIfEmpty, bool checkForCommas, int maxSize, string paramName)
        {
            if (param == null)
            {
                if (checkForNull)
                {
                    throw new ArgumentNullException(paramName);
                }
            }
            else
            {
                param = param.Trim();
                if (checkIfEmpty && (param.Length < 1))
                {
                    throw new ArgumentException("Parameter_can_not_be_empty", paramName);
                }
                if ((maxSize > 0) && (param.Length > maxSize))
                {
                    throw new ArgumentException("Parameter_too_long", paramName);
                }
                if (checkForCommas && param.Contains(","))
                {
                    throw new ArgumentException("Parameter_can_not_contain_comma", paramName);
                }
            }
        }
    }
}
