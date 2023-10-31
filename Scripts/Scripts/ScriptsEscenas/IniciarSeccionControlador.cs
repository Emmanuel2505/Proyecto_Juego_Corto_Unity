using UnityEngine;


public class IniciarSeccionControlador : MonoBehaviour
{

    private string nombreUsuarioCorrecto;
    private string contraseniaCorrecta;

    public IniciarSeccionControlador(){

        this.nombreUsuarioCorrecto = "klamer";
        this.contraseniaCorrecta = "nosequeclaveponer";
    }

    public bool comprobarUsuario(string nombreUsuario)
    {
        bool nombreUsuiarioComprobador = true;
        if (nombreUsuario == nombreUsuarioCorrecto)
        {
            nombreUsuiarioComprobador = true;
        }
        else
        {
            nombreUsuiarioComprobador = false;
        }
        return nombreUsuiarioComprobador;
    }
    public bool comprobarContrasenia(string contrasenia)
    {
        bool contraseniaComprobador = true;
        if (contrasenia == contraseniaCorrecta)
        {
            contraseniaComprobador = true;
        }
        else
        {
            contraseniaComprobador = false;
        }
        return contraseniaComprobador;
    }
}
