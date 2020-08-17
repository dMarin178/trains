using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenesV0.views;

namespace TrenesV0
{   
    class SQLiteDataAccess
    {
        //Conexion con la base de datos, ver App.config
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        //Agregar todas las funciones de acceso a la base de datos aca

        //Obtiene el usuario con el rut requerido desde la base de datos, se utiliza en el login
        public static User getUser(string rut)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<User>("SELECT * FROM Trabajador WHERE rut = @rut", new { rut = rut });
                    return query.ToList()[0];
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
        //obtiene la lista de estaciones
        public static List<Station> getStations()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = cnn.Query<Station>("SELECT * FROM estacion");
                return query.ToList();
            }
        }
        //obtiene las locomotoras que se encuentran en una estacion especifica
        public static List<Locomotive> getLocomotives(int estacion)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = cnn.Query<Locomotive>("SELECT * FROM locomotora WHERE estacion_actual = @estacion ", new {estacion = estacion });
                return query.ToList();
            }
        }
        //obtiene los materiales rodantes que se encuentran en una estacion especifica
        public static List<Material> getMaterial(int estacion)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var query = cnn.Query<Material>("SELECT * FROM material_rodante WHERE estacion_actual= @estacion ", new { estacion = estacion });
                return query.ToList();
            }
        }

        internal static object getAdmin(string text)
        {
            throw new NotImplementedException();
        }
    }
}
