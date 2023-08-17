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
     return ListaCategorias;
     }

     public static List<Dificultad> ObtenerDificultades(int idDificultad){
     List<Dificultad> ListaDificultades= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerDificultades";
        ListaDificultades = db.Query<Dificultad>(sp, new { dif = idDificultad} , 
        commandType : commandType.StoredProcedure).ToList();
     }
     return ListaDificultades;

     }
       public static List<Pregunta> ObtenerPreguntas(int idDificultad, int idCategoria){
     List<Pregunta> ListaPreguntas= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerPreguntas";
        ListaPreguntas = db.Query<Pregunta>(sp, new { preg = } , //PREGUNTAR SOBRE EL PREG Y EL IGUAL
        commandType : CommandType.StoredProcedure).ToList();
     }
     return ListaPreguntas;
       }
        public static List<Respuesta> ObtenerRespuestas(int idPreg){
     List<Respuesta> ListaRespuestas= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerRespuestas";
        ListaRespuestas = db.Query<Respuesta>(sp, new { res = idPreg} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     return ListaRespuestas;
     }















}
