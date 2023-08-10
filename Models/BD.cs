using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

static class BD{
     private static string _connectionString = @"server=localhost;DataBase=Preguntados;Trusted_connection=True;";
     public static List<Categorias> ObtenerCategorias(){
     List<Categorias> ListaCategorias= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="Traer lista categorias"
        ListaCategorias = db.Query<Categorias>(sp, new { cat = cate} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     }

     public static List<Dificultades> ObtenerDificultades(){
     List<Dificultades> ListaDificultades= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="Traer lista dificultades"
        ListaDificultades = db.Query<Dificultades>(sp, new { dif = dific} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     }















}
