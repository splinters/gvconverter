using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Esri.FileGDB;

namespace GVConverter.Classes
{
    public static class ConvertGeometryArcGIS
    {
        public static string ConvertToWkt(ShapeBuffer geometry, string typeOfGeometry, string shapeLength)
        {
            try
            {
                string retval = "";
                var shapeType = (ShapeType)geometry.shapeType;
                switch (typeOfGeometry)
                {
                    /////////////////Point/////////////////
                    //case ShapeType.Point:
                    case "Point":
                        PointShapeBuffer point = geometry;
                        retval = processPointBuffer(point);
                        break;
                    //case ShapeType.PointZ:
                    case "PointZ":
                        PointShapeBuffer pointZ = geometry;
                        retval = processPointBuffer(pointZ);
                        break;
                    //case ShapeType.PointZM:
                    case "PointZM":
                        PointShapeBuffer pointZM = geometry;
                        retval = processPointBufferZM(pointZM);
                        break;
                    /////////////////Multipoint/////////////////
                    //case ShapeType.Multipoint:
                    case "Multipoint":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPointShapeBuffer multiPoint = geometry;
                            retval = processMultiPointBuffer(multiPoint);
                        }
                        break;
                    //case ShapeType.MultipointZ:
                    case "MultipointZ":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPointShapeBuffer multiPointZ = geometry;
                            retval = processMultiPointBuffer(multiPointZ);
                        }
                        break;
                    //case ShapeType.MultipointZM:
                    case "MultipointZM":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPointShapeBuffer multiPointZM = geometry;
                            retval = processMultiPointBufferZM(multiPointZM);
                        }
                        break;
                    /////////////////Polyline/////////////////
                    //case ShapeType.Polyline:
                    case "Polyline":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPartShapeBuffer multiPartPolyline = geometry;
                            retval = processMultiPartBuffer(multiPartPolyline, "MULTILINESTRING");
                        }
                        break;
                    //case ShapeType.PolylineZ:
                    case "PolylineZ":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPartShapeBuffer multiPartPolylineZ = geometry;
                            retval = processMultiPartBuffer(multiPartPolylineZ, "MULTILINESTRING");
                        }
                        break;
                    //case ShapeType.PolylineZM:
                    case "PolylineZM":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPartShapeBuffer multiPartPolylineZM = geometry;
                            retval = processMultiPartBufferZM(multiPartPolylineZM, "MULTILINESTRING");
                        }
                        break;
                    /////////////////Polygon/////////////////
                    //case ShapeType.Polygon:
                    case "Polygon":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPartShapeBuffer multiPartPolygon = geometry;
                            retval = processMultiPartBuffer(multiPartPolygon, "MULTIPOLYGON");
                        }
                        break;
                    //case ShapeType.PolygonZ:
                    case "PolygonZ":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPartShapeBuffer multiPartPolygonZ = geometry;
                            retval = processMultiPartBuffer(multiPartPolygonZ, "MULTIPOLYGON");
                        }
                        break;
                    //case ShapeType.PolygonZM:
                    case "PolygonZM":
                        if (Convert.ToDecimal(shapeLength, CultureInfo.InvariantCulture) == 0)
                            retval = "null";
                        else
                        {
                            MultiPartShapeBuffer multiPartPolygonZM = geometry;
                            retval = processMultiPartBufferZM(multiPartPolygonZM, "MULTIPOLYGON");
                        }
                        break;
                }
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing geometry", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        private static string processPointBuffer(PointShapeBuffer buffer)
        {
            try
            {
                string retval = "ST_GeomFromText('POINT ({0})', 2039)";
                bool hasZ = false;
                string coord = hasZ ? getCoordinate(buffer.point.x, buffer.point.y, buffer.Z) : getCoordinate(buffer.point.x, buffer.point.y);
                retval = string.Format(retval, coord);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing point buffer", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        private static string processPointBufferZM(PointShapeBuffer buffer)
        {
            try
            {
                string retval = "ST_GeomFromText('POINT ({0})', 2039)";
                string coord = getCoordinate(buffer.point.x, buffer.point.y);
                retval = string.Format(retval, coord);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing point buffer", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        private static string processMultiPointBuffer(MultiPointShapeBuffer buffer)
        {
            try
            {
                string retval = "ST_GeomFromText('MULTIPOINT ({0})', 2039)";
                bool hasZ = false;
                Point[] points = buffer.Points;
                List<string> coords = new List<string>();
                for (int i = 0; i < points.Length; i++)
                {
                    string coord = hasZ ? getCoordinate(points[i].x, points[i].y, buffer.Zs[i]) : getCoordinate(points[i].x, points[i].y);
                    coords.Add(coord);
                }
                string[] coordArray = coords.ToArray();
                string coordList = string.Join(",", coordArray);
                retval = string.Format(retval, coordList);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing multipoint buffer", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        private static string processMultiPointBufferZM(MultiPointShapeBuffer buffer)
        {
            try
            {
                string retval = "ST_GeomFromText('MULTIPOINT ({0})', 2039)";
                Point[] points = buffer.Points;
                List<string> coords = new List<string>();
                for (int i = 0; i < points.Length; i++)
                {
                    string coord = getCoordinate(points[i].x, points[i].y);
                    coords.Add(coord);
                }
                string[] coordArray = coords.ToArray();
                string coordList = string.Join(",", coordArray);
                retval = string.Format(retval, coordList);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing multipoint buffer", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="wktType"></param>
        /// <returns></returns>
        private static string processMultiPartBuffer(MultiPartShapeBuffer buffer, string wktType)
        {
            try
            {
                List<string> delims = getMultipartDelimiter(wktType);
                bool hasZ = false;
                string retval = "ST_GeomFromText('" + wktType + "({0})', 2039)";
                int numPts = buffer.NumPoints;
                int numParts = buffer.NumParts;
                int[] parts = buffer.Parts;

                Point[] points = buffer.Points;
                List<string> coords = new List<string>();
                List<string> polys = new List<string>();
                int partCount = 0;
                for (int i = 0; i < numPts; i++)
                {
                    if ((partCount < numParts) && (i == parts[partCount]))
                    {
                        if (coords.Count > 0)
                        {
                            string[] coordArray = coords.ToArray();
                            string coordList = string.Join(",", coordArray);
                            polys.Add(delims[0] + coordList + delims[1]);
                        }
                        coords = new List<string>();
                        partCount++;
                    }
                    string coord = hasZ ? getCoordinate(points[i].x, points[i].y, buffer.Zs[i]) : getCoordinate(points[i].x, points[i].y);
                    coords.Add(coord);
                }
                if (coords.Count > 0)
                {
                    string[] coordArray = coords.ToArray();
                    string coordList = string.Join(",", coordArray);
                    polys.Add(delims[0] + coordList + delims[1]);
                }
                string[] polyArray = polys.ToArray();
                string polyList = string.Join(",", polyArray);
                retval = string.Format(retval, polyList);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing multipart buffer", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="wktType"></param>
        /// <returns></returns>
        private static string processMultiPartBufferZM(MultiPartShapeBuffer buffer, string wktType)
        {
            try
            {
                List<string> delims = getMultipartDelimiter(wktType);
                string retval = "ST_GeomFromText('" + wktType + "({0})', 2039)";
                int numPts = buffer.NumPoints;
                int numParts = buffer.NumParts;
                int[] parts = buffer.Parts;

                Point[] points = buffer.Points;
                List<string> coords = new List<string>();
                List<string> polys = new List<string>();
                int partCount = 0;
                for (int i = 0; i < numPts; i++)
                {
                    if ((partCount < numParts) && (i == parts[partCount]))
                    {
                        if (coords.Count > 0)
                        {
                            string[] coordArray = coords.ToArray();
                            string coordList = string.Join(",", coordArray);
                            polys.Add(delims[0] + coordList + delims[1]);
                        }
                        coords = new List<string>();
                        partCount++;
                    }
                    string coord = getCoordinate(points[i].x, points[i].y);
                    coords.Add(coord);
                }
                if (coords.Count > 0)
                {
                    string[] coordArray = coords.ToArray();
                    string coordList = string.Join(",", coordArray);
                    polys.Add(delims[0] + coordList + delims[1]);
                }
                string[] polyArray = polys.ToArray();
                string polyList = string.Join(",", polyArray);
                retval = string.Format(retval, polyList);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error processing multipart buffer", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="geoJsonType"></param>
        /// <returns></returns>
        private static List<string> getMultipartDelimiter(string geoJsonType)
        {
            try
            {
                List<string> retval = new List<string>();

                switch (geoJsonType.ToLower())
                {
                    case "multipoint":
                        retval.Add("");
                        retval.Add("");
                        break;
                    case "multilinestring":
                        retval.Add("(");
                        retval.Add(")");
                        break;
                    case "multipolygon":
                        retval.Add("((");
                        retval.Add("))");
                        break;
                }

                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating delimiters", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static string getCoordinate(double x, double y)
        {
            try
            {
                string retval = string.Format(CultureInfo.InvariantCulture, "{0} {1}", x, y);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating coordinate", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        private static string getCoordinate(double x, double y, double z)
        {
            try
            {
                string retval = string.Format(CultureInfo.InvariantCulture, "{0} {1} {2}", x, y, z);
                return retval;
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating coordinate", ex);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string getCoordinate(double x, double y, double z, double m)
        {
            try
            {
                if (double.IsNaN(m))
                {
                    m = 0;
                    string retval = string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3}", x, y, z, m);
                    return retval;
                }
                else
                {
                    string retval = string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3}", x, y, z, m);
                    return retval;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error generating coordinate", ex);
            }
        }
    }
}
