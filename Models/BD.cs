using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;
using System.Data;

static class BD{

     private static string _connectionString = @"Server=localhost;DataBase=Preguntados;Trusted_Connection=True;";
     public static List<Categoria> ObtenerCategorias()
     {
         List<Categoria> ListaCategorias= null;
         using(SqlConnection db = new SqlConnection(_connectionString))
         {
            string sp="sp_ObtenerCategorias";
            ListaCategorias = db.Query<Categoria>(sp, commandType : CommandType.StoredProcedure).ToList();
         }
         return ListaCategorias;
     }

     public static List<Dificultad> ObtenerDificultades(){
     List<Dificultad> ListaDificultades= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="sp_ObtenerDificultades";
        ListaDificultades = db.Query<Dificultad>(sp, 
        commandType : CommandType.StoredProcedure).ToList();
     }
     return ListaDificultades;

     }
       public static List<Pregunta> ObtenerPreguntas(int idDificultad, int idCategoria){
     List<Pregunta> ListaPreguntas= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="exec sp_ObtenerPreguntas @dif,@cat";
        ListaPreguntas = db.Query<Pregunta>(sp, new { dif =idDificultad,cat=idCategoria } , //PREGUNTAR SOBRE EL PREG Y EL IGUAL
        commandType : CommandType.StoredProcedure).ToList();
     }
     return ListaPreguntas;
       }
        public static List<Respuesta> ObtenerRespuestas(int idPreg){
     List<Respuesta> ListaRespuestas= null;
     using(SqlConnection db = new SqlConnection(_connectionString))
     {
        string sp="exec sp_ObtenerRespuestas @res";
        ListaRespuestas = db.Query<Respuesta>(sp, new { res = idPreg} , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     return ListaRespuestas;
     }















}
