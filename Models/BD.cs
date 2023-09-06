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
        string sp="sp_ObtenerPreguntas";
        ListaPreguntas = db.Query<Pregunta>(sp, new { IdDificultad =idDificultad,IdCategoria=idCategoria } , 
        commandType : CommandType.StoredProcedure).ToList();
     }
     return ListaPreguntas;
       }
   
      public static List<Respuesta> ObtenerRespuestas(List<Pregunta> preguntas)
      {
         List<Respuesta> ListaRespuestas= null;
         using(SqlConnection db = new SqlConnection(_connectionString))
         {
            string sp="sp_ObtenerRespuestas @idPregunta";
            foreach (Pregunta p in preguntas)
            {
               ListaRespuestas.AddRange(db.Query<Respuesta>(sp, new { idPregunta = p.IdPregunta} ,  commandType : CommandType.StoredProcedure).ToList());
            }
         }
     return ListaRespuestas;
     }

}
