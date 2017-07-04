using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GVConverter.Classes
{
    public static class StaticVariables
    {
        public static System.Int32 TotalRowsConvertToGiscuit;
        public static System.Int32 CurrentRowConvertToGiscuit;
        public static System.Int32 NewRowsAddedToGiscuit;

        public static string LoginDataBasePostgreSQL = "postgres";
        public static string PasswordDataBasePostgreSQL = "vN020213";

        public static System.Int32 TotalRowsConvertToArcGIS;
        public static System.Int32 CurrentRowConvertToArcGIS;
        public static System.Int32 NewRowsAddedToArcGIS;
        public static System.Int32 ErrorGeometryCount;

    }
}
