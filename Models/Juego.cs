public static class Juego{

private string _username{get;set;}
private int _puntajeActual{get;set;}
private int _cantidadPreguntasCorrectas{get;set;}
private static  List<Pregunta> _Preguntas {get; private set;} = new List<Pregunta>
private static List<Respuesta> _Respuestas {get; private set;} = new List<Respuesta>

public static void InicializarJuego(){
    _username=null;
    _puntajeActual=0;
    _cantidadPreguntasCorrectas=0;
}

public static List<Categoria> ObtenerCategorias(){
    return BD.ObtenerCategorias;
}

public static list<Dificultad>ObtenerDificultades(){
    return BD.ObtenerDificultades;
}





}