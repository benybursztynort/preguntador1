using System.Collections.Generic;
public static class Juego{

    public static string _username{get;set;}
    public static int _puntajeActual{get;set;}
    public static int _cantidadPreguntasCorrectas{get;set;}
    public static   List<Pregunta> _Preguntas = new List<Pregunta>();
    public static List<Respuesta> _Respuestas = new List<Respuesta>();

    public static void InicializarJuego(){
        _username=null;
        _puntajeActual=0;
        _cantidadPreguntasCorrectas=0;
    }

    public static List<Categoria> ObtenerCategorias(){
        return BD.ObtenerCategorias();
    }

    public static List<Dificultad>ObtenerDificultades(){
        return BD.ObtenerDificultades();
    }
    public static void CargarPartida(string username, int dificultad, int categoria){
        _Preguntas=BD.ObtenerPreguntas();
        _Respuestas=BD.ObtenerRespuestas();
    }
    public static void ObtenerProximaPregunta(){
        Random Pregunta =new Random();
        Pregunta.next(0,ListaPreguntas.Count());
    }
    public static List<Pregunta> ObtenerProximasRespuestas(int idPregunta){
    }
    public static bool VerificarRespuesta(int idPregunta, int idRespuesta){
        
    }
    





    }