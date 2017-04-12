using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Esri.FileGDB;

namespace GVConverter.Classes
{
    public static class ConvertGeometryGiscuitToArcGIS
    {
        public static Row GetGeometryMultipoint(Row newRow, object pgGeometryValue, int numPoints)
        {
            var geometryString = pgGeometryValue.ToString();
            var index = geometryString.IndexOf("(");
            geometryString = geometryString.Remove(0, index + 1);
            geometryString = geometryString.Replace(")", "");
            string[] valueStringArray = geometryString.Split(',');

            MultiPointShapeBuffer multipointGeometry = new MultiPointShapeBuffer();
            multipointGeometry.Setup(ShapeType.Multipoint, numPoints);
            Point[] points = multipointGeometry.Points;

            for (int i = 0; i < valueStringArray.Length; i++)
            {
                string currentItem = valueStringArray[i];
                string[] currentItemArray = currentItem.Split(' ');
                points[i].x = Convert.ToDouble(currentItemArray[0], CultureInfo.InvariantCulture);
                points[i].y = Convert.ToDouble(currentItemArray[1], CultureInfo.InvariantCulture);
            }
            multipointGeometry.Points = points;
            multipointGeometry.CalculateExtent();
            newRow.SetGeometry(multipointGeometry);

            return newRow;
        }

        public static Row GetGeometryMultipointZ(Row newRow, object valueCell, int numPoints)
        {
            string valueString = valueCell.ToString();
            int index = valueString.IndexOf("(");
            valueString = valueString.Remove(0, index + 1);
            valueString = valueString.Replace(")", "");
            string[] valueStringArray = valueString.Split(',');

            MultiPointShapeBuffer multipointGeometry = new MultiPointShapeBuffer();
            multipointGeometry.Setup(ShapeType.Multipoint, numPoints);
            Point[] points = multipointGeometry.Points;
            double[] pointsZ = multipointGeometry.Zs;

            for (int i = 0; i < valueStringArray.Length; i++)
            {
                string currentItem = valueStringArray[i];
                string[] currentItemArray = currentItem.Split(' ');
                points[i].x = Convert.ToDouble(currentItemArray[0], CultureInfo.InvariantCulture);
                points[i].y = Convert.ToDouble(currentItemArray[1], CultureInfo.InvariantCulture);
                pointsZ[i] = Convert.ToDouble(currentItemArray[2], CultureInfo.InvariantCulture);
            }
            multipointGeometry.Points = points;
            multipointGeometry.Zs = pointsZ;
            multipointGeometry.CalculateExtent();
            newRow.SetGeometry(multipointGeometry);

            return newRow;
        }

        public static Row GetGeometryMultipointZM(Row newRow, object valueCell, int numPoints)
        {
            string valueString = valueCell.ToString();
            int index = valueString.IndexOf("(");
            valueString = valueString.Remove(0, index + 1);
            valueString = valueString.Replace(")", "");
            string[] valueStringArray = valueString.Split(',');

            MultiPointShapeBuffer multipointGeometry = new MultiPointShapeBuffer();
            multipointGeometry.Setup(ShapeType.Multipoint, numPoints);
            Point[] points = multipointGeometry.Points;
            double[] pointsZ = multipointGeometry.Zs;
            double[] pointsM = multipointGeometry.Ms;

            for (int i = 0; i < valueStringArray.Length; i++)
            {
                string currentItem = valueStringArray[i];
                string[] currentItemArray = currentItem.Split(' ');
                points[i].x = Convert.ToDouble(currentItemArray[0], CultureInfo.InvariantCulture);
                points[i].y = Convert.ToDouble(currentItemArray[1], CultureInfo.InvariantCulture);
                pointsZ[i] = Convert.ToDouble(currentItemArray[2], CultureInfo.InvariantCulture);
                pointsM[i] = Convert.ToDouble(currentItemArray[3], CultureInfo.InvariantCulture);
            }
            multipointGeometry.Points = points;
            multipointGeometry.Zs = pointsZ;
            multipointGeometry.Ms = pointsM;
            multipointGeometry.CalculateExtent();
            newRow.SetGeometry(multipointGeometry);

            return newRow;
        }

        public static Row GetGeometryPoint(Row newRow, object valueCell)
        {
            string valueString = valueCell.ToString();
            int index = valueString.IndexOf("(");
            valueString = valueString.Remove(0, index + 1);
            valueString = valueString.Replace(")", "");
            string[] valueStringArray = valueString.Split(' ');

            PointShapeBuffer pointShapeBuffer=new PointShapeBuffer();
            pointShapeBuffer.Setup(ShapeType.Point);
            Point point = new Point(Convert.ToDouble(valueStringArray[0], CultureInfo.InvariantCulture), Convert.ToDouble(valueStringArray[1], CultureInfo.InvariantCulture));
            pointShapeBuffer.point = point;
            newRow.SetGeometry(pointShapeBuffer);

            return newRow;
        }

        public static Row GetGeometryPointZ(Row newRow, object valueCell)
        {
            string valueString = valueCell.ToString();
            int index = valueString.IndexOf("(");
            valueString = valueString.Remove(0, index + 1);
            valueString = valueString.Replace(")", "");
            string[] valueStringArray = valueString.Split(' ');

            PointShapeBuffer pointShapeBuffer = new PointShapeBuffer();
            pointShapeBuffer.Setup(ShapeType.PointZ);
            Point point = new Point(Convert.ToDouble(valueStringArray[0], CultureInfo.InvariantCulture), Convert.ToDouble(valueStringArray[1], CultureInfo.InvariantCulture));
            pointShapeBuffer.point = point;
            pointShapeBuffer.Z = Convert.ToDouble(valueStringArray[2], CultureInfo.InvariantCulture); // Z
            newRow.SetGeometry(pointShapeBuffer);

            return newRow;
        }

        public static Row GetGeometryPointZM(Row newRow, object valueCell)
        {
            string valueString = valueCell.ToString();
            int index = valueString.IndexOf("(");
            valueString = valueString.Remove(0, index + 1);
            valueString = valueString.Replace(")", "");
            string[] valueStringArray = valueString.Split(' ');

            PointShapeBuffer pointShapeBuffer = new PointShapeBuffer();
            pointShapeBuffer.Setup(ShapeType.PointZM);
            Point point = new Point(Convert.ToDouble(valueStringArray[0], CultureInfo.InvariantCulture), Convert.ToDouble(valueStringArray[1], CultureInfo.InvariantCulture));
            pointShapeBuffer.point = point;
            pointShapeBuffer.Z = Convert.ToDouble(valueStringArray[2], CultureInfo.InvariantCulture); // Z
            pointShapeBuffer.M = Convert.ToDouble(valueStringArray[3], CultureInfo.InvariantCulture); // M
            newRow.SetGeometry(pointShapeBuffer);

            return newRow;
        }

        public static Row GetGeometryPolynie(Row newRow, object valueCell, int numGeometries, int numPoints)
        {
            int countPoint = 0;int countParts = 0;

            MultiPartShapeBuffer polylineMultiPartShapeBuffer = new MultiPartShapeBuffer();
            polylineMultiPartShapeBuffer.Setup(ShapeType.Polyline, numGeometries, numPoints);
            int[] parts = polylineMultiPartShapeBuffer.Parts;
            Point[] points = polylineMultiPartShapeBuffer.Points; 
            
            string geometry = valueCell.ToString().Remove(0, 16); 
            geometry = geometry.Remove(geometry.Length - 1); 
            geometry = geometry.Replace("),(", ");(");
            string[] newgeometry = geometry.Split(';'); 
            
            for (int i = 0; i < newgeometry.Length; i++)
            {
                parts[countParts] = countPoint;
                countParts++;

                string valueOneItemArray = newgeometry[i];
                valueOneItemArray = valueOneItemArray.Replace("(", "");
                valueOneItemArray = valueOneItemArray.Replace(")", "");
                string[] valueArray = valueOneItemArray.Split(','); 
                for (int j = 0; j < valueArray.Length; j++)
                {
                    string valueOneItemArray1 = valueArray[j];
                    string[] valueArray1 = valueOneItemArray1.Split(' ');
                    points[countPoint].x = Convert.ToDouble(valueArray1[0], CultureInfo.InvariantCulture);
                    points[countPoint].y = Convert.ToDouble(valueArray1[1], CultureInfo.InvariantCulture);
                    countPoint++;
                }
            }

            polylineMultiPartShapeBuffer.Points = points; 
            polylineMultiPartShapeBuffer.Parts = parts; 
            polylineMultiPartShapeBuffer.CalculateExtent();
            newRow.SetGeometry(polylineMultiPartShapeBuffer);
            return newRow;
            throw new NotImplementedException();

        }

        public static Row GetGeometryPolynieZ(Row newRow, object valueCell, int numGeometries, int numPoints)
        {
            int countPoint = 0; 
            int countParts = 0;

            MultiPartShapeBuffer polylineMultiPartShapeBuffer = new MultiPartShapeBuffer();
            polylineMultiPartShapeBuffer.Setup(ShapeType.PolylineZ, numGeometries, numPoints);
            int[] parts = polylineMultiPartShapeBuffer.Parts; 
            Point[] points = polylineMultiPartShapeBuffer.Points;
            double[] pointsZ = polylineMultiPartShapeBuffer.Zs;

            string geometry = valueCell.ToString().Remove(0, 16);
            geometry = geometry.Remove(geometry.Length - 1);
            geometry = geometry.Replace("),(", ");(");
            string[] newgeometry = geometry.Split(';');

            for (int i = 0; i < newgeometry.Length; i++)
            {
                parts[countParts] = countPoint;
                countParts++;

                string valueOneItemArray = newgeometry[i];
                valueOneItemArray = valueOneItemArray.Replace("(", "");
                valueOneItemArray = valueOneItemArray.Replace(")", "");
                string[] valueArray = valueOneItemArray.Split(',');
                for (int j = 0; j < valueArray.Length; j++)
                {
                    string valueOneItemArray1 = valueArray[j];
                    string[] valueArray1 = valueOneItemArray1.Split(' ');
                    
                    points[countPoint].x = Convert.ToDouble(valueArray1[0], CultureInfo.InvariantCulture);
                    points[countPoint].y = Convert.ToDouble(valueArray1[1], CultureInfo.InvariantCulture);
                    pointsZ[countPoint] = Convert.ToDouble(valueArray1[2], CultureInfo.InvariantCulture);
                    countPoint++;
                }
            }
            polylineMultiPartShapeBuffer.Points = points;
            polylineMultiPartShapeBuffer.Zs = pointsZ;
            polylineMultiPartShapeBuffer.Parts = parts;
            polylineMultiPartShapeBuffer.CalculateExtent();
            newRow.SetGeometry(polylineMultiPartShapeBuffer);
            return newRow;
        }

        public static Row GetGeometryPolynieZM(Row newRow, object valueCell, int numGeometries, int numPoints)
        {
            int countPoint = 0; 
            int countParts = 0;

            MultiPartShapeBuffer polylineMultiPartShapeBuffer = new MultiPartShapeBuffer();
            polylineMultiPartShapeBuffer.Setup(ShapeType.PolylineZM, numGeometries, numPoints);
            int[] parts = polylineMultiPartShapeBuffer.Parts;
            Point[] points = polylineMultiPartShapeBuffer.Points; 
            double[] pointsZ = polylineMultiPartShapeBuffer.Zs; 
            double[] pointsM = polylineMultiPartShapeBuffer.Ms; 

            string geometry = valueCell.ToString().Remove(0, 16);
            geometry = geometry.Remove(geometry.Length - 1);
            geometry = geometry.Replace("),(", ");(");
            string[] newgeometry = geometry.Split(';');

            for (int i = 0; i < newgeometry.Length; i++)
            {
                parts[countParts] = countPoint;
                countParts++;

                string valueOneItemArray = newgeometry[i];
                valueOneItemArray = valueOneItemArray.Replace("(", "");
                valueOneItemArray = valueOneItemArray.Replace(")", "");
                string[] valueArray = valueOneItemArray.Split(',');
                for (int j = 0; j < valueArray.Length; j++)
                {
                    string valueOneItemArray1 = valueArray[j];
                    string[] valueArray1 = valueOneItemArray1.Split(' ');

                    points[countPoint].x = Convert.ToDouble(valueArray1[0], CultureInfo.InvariantCulture);
                    points[countPoint].y = Convert.ToDouble(valueArray1[1], CultureInfo.InvariantCulture);
                    pointsZ[countPoint] = Convert.ToDouble(valueArray1[2], CultureInfo.InvariantCulture);
                    pointsM[countPoint] = Convert.ToDouble(valueArray1[3], CultureInfo.InvariantCulture);
                    countPoint++;
                }
            }
            polylineMultiPartShapeBuffer.Points = points; // X и Y 
            polylineMultiPartShapeBuffer.Zs = pointsZ; // Z
            polylineMultiPartShapeBuffer.Ms = pointsM; // M
            polylineMultiPartShapeBuffer.Parts = parts; //
            polylineMultiPartShapeBuffer.CalculateExtent();
            newRow.SetGeometry(polylineMultiPartShapeBuffer);
            return newRow;
        }

        public static Row GetGeometryMultipolygon(Row newRow, object valueCell, int numGeometries, int numPoints)
        {
            int countPoint = 0;
            int countParts = 0;

            MultiPartShapeBuffer polylineMultiPartShapeBuffer = new MultiPartShapeBuffer();
            polylineMultiPartShapeBuffer.Setup(ShapeType.Polygon, numGeometries, numPoints);
            int[] parts = polylineMultiPartShapeBuffer.Parts;
            Point[] points = polylineMultiPartShapeBuffer.Points;
            
            string geometry = valueCell.ToString().Remove(0, 13); 
            geometry = geometry.Remove(geometry.Length - 1); 
            geometry = geometry.Replace("),(", ");(");
            string[] newgeometry = geometry.Split(';'); 

            for (int i = 0; i < newgeometry.Length; i++)
            {
                parts[countParts] = countPoint;
                countParts++;

                string valueOneItemArray = newgeometry[i];
                valueOneItemArray = valueOneItemArray.Replace("(", "");
                valueOneItemArray = valueOneItemArray.Replace(")", "");
                string[] valueArray = valueOneItemArray.Split(','); 
                for (int j = 0; j < valueArray.Length; j++)
                {
                    string valueOneItemArray1 = valueArray[j];
                    string[] valueArray1 = valueOneItemArray1.Split(' ');
                    
                    points[countPoint].x = Convert.ToDouble(valueArray1[0], CultureInfo.InvariantCulture);
                    points[countPoint].y = Convert.ToDouble(valueArray1[1], CultureInfo.InvariantCulture);
                    countPoint++;
                }
            }

            polylineMultiPartShapeBuffer.Points = points; 
            polylineMultiPartShapeBuffer.Parts = parts;
            polylineMultiPartShapeBuffer.CalculateExtent();
            newRow.SetGeometry(polylineMultiPartShapeBuffer);
            return newRow;
        }

        public static Row GetGeometryMultipolygonZ(Row newRow, object valueCell, int numGeometries, int numPoints)
        {
            int countPoint = 0;
            int countParts = 0;

            MultiPartShapeBuffer polylineMultiPartShapeBuffer = new MultiPartShapeBuffer();
            polylineMultiPartShapeBuffer.Setup(ShapeType.PolygonZ, numGeometries, numPoints);
            int[] parts = polylineMultiPartShapeBuffer.Parts;
            Point[] points = polylineMultiPartShapeBuffer.Points;
            double[] pointsZ = polylineMultiPartShapeBuffer.Zs;

            string geometry = valueCell.ToString().Remove(0, 16);
            geometry = geometry.Remove(geometry.Length - 1);
            geometry = geometry.Replace("),(", ");(");
            string[] newgeometry = geometry.Split(';');

            for (int i = 0; i < newgeometry.Length; i++)
            {
                parts[countParts] = countPoint;
                countParts++;

                string valueOneItemArray = newgeometry[i];
                valueOneItemArray = valueOneItemArray.Replace("(", "");
                valueOneItemArray = valueOneItemArray.Replace(")", "");
                string[] valueArray = valueOneItemArray.Split(',');
                for (int j = 0; j < valueArray.Length; j++)
                {
                    string valueOneItemArray1 = valueArray[j];
                    string[] valueArray1 = valueOneItemArray1.Split(' ');

                    points[countPoint].x = Convert.ToDouble(valueArray1[0], CultureInfo.InvariantCulture);
                    points[countPoint].y = Convert.ToDouble(valueArray1[1], CultureInfo.InvariantCulture);
                    pointsZ[countPoint] = Convert.ToDouble(valueArray1[2], CultureInfo.InvariantCulture);
                    countPoint++;
                }
            }
            polylineMultiPartShapeBuffer.Points = points; 
            polylineMultiPartShapeBuffer.Zs = pointsZ;
            polylineMultiPartShapeBuffer.Parts = parts; 
            polylineMultiPartShapeBuffer.CalculateExtent();
            newRow.SetGeometry(polylineMultiPartShapeBuffer);
            return newRow;
        }

        public static Row GetGeometryMultipolygonZM(Row newRow, object valueCell, int numGeometries, int numPoints)
        {
            int countPoint = 0; 
            int countParts = 0;

            MultiPartShapeBuffer polylineMultiPartShapeBuffer = new MultiPartShapeBuffer();
            polylineMultiPartShapeBuffer.Setup(ShapeType.PolygonZM, numGeometries, numPoints);
            int[] parts = polylineMultiPartShapeBuffer.Parts;
            Point[] points = polylineMultiPartShapeBuffer.Points;
            double[] pointsZ = polylineMultiPartShapeBuffer.Zs;
            double[] pointsM = polylineMultiPartShapeBuffer.Ms;

            string geometry = valueCell.ToString().Remove(0, 16);
            geometry = geometry.Remove(geometry.Length - 1);
            geometry = geometry.Replace("),(", ");(");
            string[] newgeometry = geometry.Split(';');

            for (int i = 0; i < newgeometry.Length; i++)
            {
                parts[countParts] = countPoint;
                countParts++;

                string valueOneItemArray = newgeometry[i];
                valueOneItemArray = valueOneItemArray.Replace("(", "");
                valueOneItemArray = valueOneItemArray.Replace(")", "");
                string[] valueArray = valueOneItemArray.Split(',');
                for (int j = 0; j < valueArray.Length; j++)
                {
                    string valueOneItemArray1 = valueArray[j];
                    string[] valueArray1 = valueOneItemArray1.Split(' ');

                    points[countPoint].x = Convert.ToDouble(valueArray1[0], CultureInfo.InvariantCulture);
                    points[countPoint].y = Convert.ToDouble(valueArray1[1], CultureInfo.InvariantCulture);
                    pointsZ[countPoint] = Convert.ToDouble(valueArray1[2], CultureInfo.InvariantCulture);
                    pointsM[countPoint] = Convert.ToDouble(valueArray1[3], CultureInfo.InvariantCulture);
                    countPoint++;
                }
            }
            polylineMultiPartShapeBuffer.Points = points; // X и Y 
            polylineMultiPartShapeBuffer.Zs = pointsZ; // Z
            polylineMultiPartShapeBuffer.Ms = pointsM; // M
            polylineMultiPartShapeBuffer.Parts = parts; 
            polylineMultiPartShapeBuffer.CalculateExtent();
            newRow.SetGeometry(polylineMultiPartShapeBuffer);
            return newRow;
        }
    }
}
