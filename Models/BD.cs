using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

static class BD{
     private static string _connectionString = @"Server=localhost;DataBase=Preguntados;Trusted_Connection=True;";
     public static List<Categoria> ObtenerCategorias(int idCategoria){
     List<Categoria> ListaCategorias= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerCategorias";
        ListaCategorias = db.Query<Categoria>(sp, new { cat = idCategoria} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     }

     public static List<Dificultad> ObtenerDificultades(int idDificultad){
     List<Dificultad> ListaDificultades= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerDificultades";
        ListaDificultades = db.Query<Dificultad>(sp, new { dif = idDificultad} , 
        commandType : CommandType.StoredProcedure).ToList();
     }

     }
       public static List<Pregunta> ObtenerPreguntas(int idDificultad, int idCategoria){
         string pregu;
     List<Pregunta> ListaPreguntas= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerPreguntas";
        ListaPreguntas = db.Query<Pregunta>(sp, new { preg = pregu} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
       }
        public static List<Respuesta> ObtenerRespuestas(int idPreg){
     List<Respuesta> ListaRespuestas= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerRespuestas";
        ListaRespuestas = db.Query<Respuesta>(sp, new { res = idPreg} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     }















}
