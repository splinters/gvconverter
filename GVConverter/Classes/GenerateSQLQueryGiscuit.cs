using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using Esri.FileGDB;

namespace GVConverter.Classes
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class GenerateSQLQueryGiscuit
    {
        public static string GetGeometry(string shapeType)
        {
            try
            {
                string retval = "";
                switch (shapeType)
                {
                    ///////////////// Multipoint /////////////////
                    case "Multipoint":
                        retval = Multipoint();
                        break;
                    case "MultipointZ":
                        retval = Multipoint();
                        //retval = MultipointZ();
                        break;
                    case "MultipointZM":
                        retval = Multipoint();
                        //retval = MultipointZM();
                        break;
                    ///////////////// Point /////////////////
                    case "Point":
                        retval = Point();
                        break;
                    case "PointZ":
                        retval = Point();
                        //retval = PointZ();
                        break;
                    case "PointZM":
                        retval = Point();
                        //retval = PointZM();
                        break;
                    ///////////////// Polyline /////////////////
                    case "Polyline":
                        retval = Polyline();
                        break;
                    case "PolylineZ":
                        retval = Polyline();
                        //retval = PolylineZ();
                        break;
                    case "PolylineZM":
                        retval = Polyline();
                        //retval = PolylineZM();
                        break;
                    ///////////////// Polygon /////////////////
                    case "Polygon":
                        retval = Polygon();
                        break;
                    case "PolygonZ":
                        retval = Polygon();
                        //retval = PolygonZ();
                        break;
                    case "PolygonZM":
                        retval = Polygon();
                        //retval = PolygonZM();
                        break;
                    default:
                        MessageBox.Show(@"Unknown type of geometry", @"Error geometry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing geometry", ex);
            }
        }

        private static string Multipoint()
        {
            return "the_geom geometry(MULTIPOINT),";
        }

        private static string MultipointZ()
        {
            return "the_geom geometry(MULTIPOINTZ),";
        }

        private static string MultipointZM()
        {
            return "the_geom geometry(MULTIPOINTZM),";
        }

        private static string Point()
        {
            return "the_geom geometry(POINT),";
        }

        private static string PointZ()
        {
            return "the_geom geometry(POINTZ),";
        }

        private static string PointZM()
        {
            return "the_geom geometry(POINTZM),";
        }

        private static string Polyline()
        {
            return "the_geom geometry(MULTILINESTRING),";
        }

        private static string PolylineZ()
        {
            return "the_geom geometry(MULTILINESTRINGZ),";
        }

        private static string PolylineZM()
        {
            return "the_geom geometry(MULTILINESTRINGZM),";
        }

        private static string Polygon()
        {
            return "the_geom geometry(MULTIPOLYGON),";
        }

        private static string PolygonZ()
        {
            return "the_geom geometry(MULTIPOLYGONZ),";
        }

        private static string PolygonZM()
        {
            return "the_geom geometry(MULTIPOLYGONZM),";
        }

        public static string OtherFields(string nameTable)
        {
            return new WorkArcGIS().GetFieldNameAndType(nameTable);
        }
    }
}
