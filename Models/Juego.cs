using System.Collections.Generic;
public static class Juego{

    private static string _username = "";
    public static int _puntajeActual{get;set;}
    public static int _cantidadPreguntasCorrectas{get;set;}
    public static   List<Pregunta> _Preguntas = new List<Pregunta>();
    public static List<Respuesta> _Respuestas = new List<Respuesta>();

    public static string username
    {
        get { return _username; }
        set { _username = value; }
    }

    public static void InicializarJuego(){
        _username= "";
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
        // obtengo la lista de preguntas
        _Preguntas=BD.ObtenerPreguntas(dificultad,categoria);
        // con las preguntas que recibi, carga respuestas
        _Respuestas=BD.ObtenerRespuestas(_Preguntas);
    }
    public static Pregunta ObtenerProximaPregunta(){
 

        if(_Preguntas.Count() != 0)
        {
            Random random = new Random();
            int preguntaRandom = random.Next(0, _Preguntas.Count());
            Pregunta preguntaElegidaAlAzar = _Preguntas[preguntaRandom];

        if (_Preguntas.Count() > 3)
        {
            _Preguntas.RemoveAt(preguntaRandom);
        }

        return preguntaElegidaAlAzar;
        }

        else {
            return null;
        }


        
    }
    public static List<Respuesta> ObtenerProximasRespuestas(int idPregunta){
        List<Respuesta>listRespuesta = new List<Respuesta>();

        foreach (Respuesta item in listRespuesta)
        {
            if (item.IdPregunta==idPregunta)
            {
                listRespuesta.Add(item);
            }
        }
        // for(int x = 0; x < _Respuestas.Count();x ++){
        //     if(_Respuestas[x].IdPregunta==idPregunta)
        //     listRespuesta.Add(_Respuestas[x]);
        // }
        return listRespuesta;
    }

    //devolver true si la respuesta es correcta y si la respuesta corresponde con la pregunta
    // devolver false en otros casos
    public static bool VerificarRespuesta(int idPregunta, int idrRespuesta){

        if (_Respuestas[idrRespuesta].IdPregunta!=idPregunta || _Respuestas[idrRespuesta].Correcta!=false )
        {
          return false;
        }
        
        int _puntajeActual=0;
        _puntajeActual  =_puntajeActual+100;
        _cantidadPreguntasCorrectas++;
        return true;
        
    }
    
}