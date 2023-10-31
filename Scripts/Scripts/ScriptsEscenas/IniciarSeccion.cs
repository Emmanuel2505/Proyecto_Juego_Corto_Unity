using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class IniciarSeccion : MonoBehaviour, ICambioEscena
{
    [SerializeField] private TMP_InputField n_NombreUsuarioInput = null;
    [SerializeField] private TMP_InputField n_ContraseniaInput = null;
    [SerializeField] private TMP_Text n_Texto = null;


    public void cambiarEscena()
    {
        IniciarSeccionControlador controlador = new IniciarSeccionControlador();
        if (n_NombreUsuarioInput.text == "" || n_ContraseniaInput.text == "")
        {
            n_Texto.text = "Por favor llene todos los campos";
        }
        else
        {
            if (controlador.comprobarUsuario(n_NombreUsuarioInput.text))
            {
                if (controlador.comprobarContrasenia(n_ContraseniaInput.text))
                {
                    SceneManager.LoadScene(1);
                }
                else
                {
                    n_Texto.text = "Contreseña Incorrecta";
                }
            }
            else
            {
                n_Texto.text = "Nombre de Usuario Incorrecto";
            }
        }
    }


    public void cerrarJuego()
    {
        //Para salir del juego
        Application.Quit();
        Debug.Log("Salir");
    }
}
