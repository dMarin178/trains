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
using TrenesV0.controllers;
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
        //OBtiene los usuarios y los retorna para trabajarlos en sistema
        public static List<User> getUsers()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<User>("SELECT * FROM Trabajador");
                    return query.ToList();
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        public static List<Station> getStationsComplete()
        {
            try
            {
                List<Station> estaciones = new List<Station>();
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<Station>("SELECT * FROM estacion");
                    estaciones = query.ToList();
                    foreach (Station station in estaciones)
                    {
                        long nEstacion = station.nroEstacion;
                        var sql = "Select mr.idMaterialR,mr.marca,mr.peso,l.fuerza " +
                                  "FROM estacion e " +
                                  "INNER JOIN estacionMaterial emr on e.nroEstacion = emr.nroEstacion " +
                                  "INNER JOIN materialRodante mr on mr.idMaterialR = emr.idMaterialR " +
                                  "INNER JOIN locomotora l on l.idLocomotora = mr.idMaterialR" +
                                  "WHERE e.nroEstacion = @id;";
                        var queryLocomotoras = cnn.Query<Locomotive>(sql, new { id = nEstacion });
                        var locomotoras = queryLocomotoras.ToList();
                        sql = "Select mr.idMaterialR,mr.marca,mr.peso,c.idProducto " +
                                  "FROM estacion e " +
                                  "INNER JOIN estacionMaterial emr on e.nroEstacion = emr.nroEstacion " +
                                  "INNER JOIN materialRodante mr on mr.idMaterialR = emr.idMaterialR " +
                                  "INNER JOIN carro c on c.idCarro = mr.idMaterialR" +
                                  "WHERE e.nroEstacion = @id;";
                        var queryCarros = cnn.Query<Carro>(sql, new { id = nEstacion });
                        var carros = queryCarros.ToList();
                        foreach(Locomotive loco in locomotoras)
                        {
                            station.materiales.Add(loco);
                        }
                        foreach(Carro carro in carros)
                        {
                            station.materiales.Add(carro);
                        }
                    }
                }
                if (estaciones.Count() == 0)
                {
                    Console.WriteLine("Error, no existe ninguna loco");
                }
                else
                {
                    return estaciones;
                }
                
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;

        }
        //obtiene la lista de estaciones
        public static List<Producto> getProducts()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<Producto>("SELECT * FROM producto");
                    return query.ToList();
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;

        }
        public static List<Station> getStations()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<Station>("SELECT * FROM estacion");
                    return query.ToList();
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
        //obtiene los materiales en una estacion especifica
        public static List<MaterialRodante> getMaterialRodante(int estacion)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<MaterialRodante>("SELECT * FROM estacionMaterial WHERE nroEstacion = @estacion ", new { estacion = estacion });
                    return query.ToList();
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
        //obtiene las locomotoras que se encuentran en una estacion especifica
        public static List<Locomotive> getLocomotives(int estacion)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var sql = "SELECT l.idLocomotora AS id, mr.marca, mr.peso, l.fuerza  FROM locomotora AS l INNER JOIN estacionMaterial AS em ON l.idLocomotora=em.idMaterialR INNER JOIN materialRodante AS mr ON mr.idMaterialR=l.idLocomotora WHERE em.nroEstacion = @estacion";
                    var query = cnn.Query<Locomotive>(sql, new { estacion = estacion });
                    return query.ToList();
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
        //obtiene los carros que se encuentran en una estacion especifica
        public static List<Carro> getCarro(int estacion)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<Carro>("SELECT c.idCarro AS id, mr.marca, mr.peso, C.idProducto  FROM carro AS c INNER JOIN estacionMaterial as em ON c.idCarro=em.idMaterialR INNER JOIN materialRodante AS mr ON mr.idMaterialR=c.idCarro WHERE em.nroEstacion = @estacion", new { estacion = estacion });
                    return query.ToList();
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
        //obtiene los datos del admin asociado al rut
        public static Admin getAdmin(string rut)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var query = cnn.Query<Admin>("SELECT * FROM Admin WHERE rut = @rut", new { rut = rut });
                    return query.ToList()[0];
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
        public static long getLastTrain()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    long query = cnn.Query<long>("SELECT rowid FROM tren;" ).Last();
                    return query;
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }
        public static long getLastViaje()
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    long query = cnn.Query<long>("SELECT rowid FROM viaje;").Last();
                    return query;
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }
        //INSERTS
        public static void setTren(Tren tren)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO tren (idTren, idLocoTiradora, rutCreador) VALUES (@idTren, @idLocoTiradora, @rutCreador)", tren);
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void setViaje(Viaje viaje)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO viaje (idViaje, idTren, nroEstacionOrigen, nroEstacionFinal, rutCreador, fechaHoraSalida) VALUES (@idViaje, @idTren, @nroEstacionOrigen, @nroEstacionFinal, @rutCreador, @fechaHoraSalida)", viaje);
                }

            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void setTrenMaterialRodante(long idTren, long idMaterialR)
        {
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute("INSERT INTO trenMaterialRodante (idTren, idMaterialR) VALUES (@idTren, @idMaterialR)", new { idTren = idTren, idMaterialR = idMaterialR });
                }
            }
            catch (SQLiteException sqle)
            {
                Console.WriteLine(sqle);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
