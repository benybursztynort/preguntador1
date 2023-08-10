using System.Data.SqlClient;
using System.Collections.Generic;
using Dapper;

static class BD{
     private static string _connectionString = @"server=localhost;DataBase=Preguntados;Trusted_connection=True;";
     public static list<Categoria> ObtenerCategorias(int idCategoria){
           Candidato MiCategoria = null;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT Nombre FROM Categorias WHERE IdCategoria=@Categoria";
            MiCategoria = db.QueryFirstOrDefault<Categoria>(SQL, new { Categoria = idCategoria });
        }
        return MiCategoria;
     }
       public static list<Categoria> ObtenerDificultades(int idDificultad){
           Candidato MiDificultad = null;
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string SQL = "SELECT Nombre FROM Categorias WHERE IdCategoria=@Categoria";
            MiCategoria = db.QueryFirstOrDefault<Categoria>(SQL, new { Categoria = idCategoria });
        }
        return MiCategoria;
     }
}