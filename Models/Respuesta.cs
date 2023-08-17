public class Respuesta{
    public int IdrRespuesta{get;set;}
    public int IdPregunta{get;set;}
    public int Opcion{get;set;}
    public string Contenido{get;set;}
    public string Foto{get;set;}
    public bool Correcta{get;set;}

    public Respuesta(){}
    public Respuesta(int idrRespuesta,int idPregunta, int opcion, string contenido, string foto, bool correcta){
        IdrRespuesta=idrRespuesta;
        IdPregunta=idPregunta;
        Opcion=opcion;
        Contenido=contenido;
        Foto=foto;
        Correcta=correcta;
    }


}