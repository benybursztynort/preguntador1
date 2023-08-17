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

    public static List<Categoria> ObtenerCategorias(int idCategoria){
        return BD.ObtenerCategorias(idCategoria);
    }

    public static List<Dificultad>ObtenerDificultades(int idDificultad){
        return BD.ObtenerDificultades(idDificultad);
    }
    public static void CargarPartida(string username, int dificultad, int categoria, int idPreg, int idDificultad, int idCategoria){
        _Preguntas=BD.ObtenerPreguntas(idDificultad,idCategoria);
        _Respuestas=BD.ObtenerRespuestas(idPreg);
    }
    public static void ObtenerProximaPregunta(List<Pregunta>ListaPreguntas){
        Random Pregunta =new Random();
        Pregunta.Next(0,ListaPreguntas.Count());
    }
    public static List<Respuesta> ObtenerProximasRespuestas(int idPregunta){
        List<Respuesta>listRespuesta = new List<Respuesta>();
        for(int x = 0; x < _Respuestas.Count();x ++){
            if(_Respuestas[x].IdPregunta==idPregunta)
            listRespuesta.Add(_Respuestas[x]);
        }
        return listRespuesta;
    }
    public static bool VerificarRespuesta(int idPregunta, int idrRespuesta){
        Pregunta pregunta;
        Respuesta respuesta;
        for(int x =0; x< _Respuestas.Count();x++){
            if(_Respuestas[x].IdrRespuesta ==idrRespuesta){
                respuesta = _Respuestas[x];
                break;
            }
        }
            for (int x = 0; x < _Preguntas.Count(); x++){
            if (_Preguntas[x].IdPregunta == idPregunta){
                _Preguntas.RemoveAt(x);
                break;
            }
        }
        if (respuesta.Correcta){
            int _puntajeActual=0;
            _puntajeActual  =_puntajeActual+100;
            _cantidadPreguntasCorrectas++;
            return true;
        }
        return false;
        }
    }
    
    