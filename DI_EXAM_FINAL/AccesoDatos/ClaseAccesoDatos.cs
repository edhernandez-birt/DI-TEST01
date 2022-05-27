using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesNW;

namespace AccesoDatos
{
    public class ClaseAccesoDatos
    {
        public static string RealizarConsultaBD()
        {
            string lista = "LISTA BD"+Environment.NewLine;
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=di;Password=1234");
            SqlCommand command;
            string sql = "select * from categories";
            SqlDataReader dataReader;

            try
            {
                conn.Open();
                command = new SqlCommand(sql,conn); //IMPORTANTE PASAR LA CONEXION
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    lista += dataReader.GetValue(0)+" "+ dataReader.GetValue(1) + " "+ dataReader.GetValue(2)+Environment.NewLine;
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return lista;
        }

        public static List<FacturacionRegionesDTO> ListaFacturacionRegiones()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Northwind;User ID=edu;Password=1234");
            SqlCommand command;
            string sql = @"WITH    EmployeeSales
          AS(SELECT   e.EmployeeID,
                        e.LastName,
                        SUM(od.Quantity * od.UnitPrice * (1 - Discount)) ESales
               FROM     dbo.Employees AS e
                        INNER JOIN dbo.Orders AS o ON e.EmployeeID = o.EmployeeID
                        INNER JOIN dbo.[Order Details] AS od ON o.OrderID = od.OrderID
               GROUP BY e.EmployeeID,
                        e.LastName
             ),
        EmployeeRegion
          AS(SELECT DISTINCT
                        EmployeeID,
                        r.RegionID,
                        RegionDescription
               FROM     dbo.Region AS r
                        INNER JOIN dbo.Territories AS t ON r.RegionID = t.RegionID
                        INNER JOIN dbo.EmployeeTerritories AS et ON t.TerritoryID = et.TerritoryID
             )
    SELECT EmployeeRegion.RegionID ,
            EmployeeRegion.RegionDescription ,
            SUM(EmployeeSales.ESales) RegionTotalSale
    FROM    EmployeeSales
            INNER JOIN EmployeeRegion ON EmployeeSales.EmployeeID = EmployeeRegion.EmployeeID
    GROUP BY EmployeeRegion.RegionID ,
            EmployeeRegion.RegionDescription";

            SqlDataReader datos;

            try
            {
                conn.Open();
                Console.WriteLine("Conexion con la BD abierta con exito");
                command = new SqlCommand(sql, conn);
                datos = command.ExecuteReader();
                List<FacturacionRegionesDTO> listaFacturacion = new List<FacturacionRegionesDTO>();
                while (datos.Read())
                {
                    FacturacionRegionesDTO region = new FacturacionRegionesDTO();
                    region.RegionId = (int)Int64.Parse(datos.GetValue(0).ToString());
                    region.RegionNombre = datos.GetValue(1).ToString();
                    region.RegionFacturacion = Math.Round(Double.Parse(datos.GetValue(2).ToString()),2);
                    listaFacturacion.Add(region);
                }
                Console.WriteLine("Query realizada con exito");
                datos.Close();
                command.Dispose();
                return listaFacturacion;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                conn.Close();
                Console.WriteLine("Conexion cerrada con la BD");
            }
        }
    }
}
