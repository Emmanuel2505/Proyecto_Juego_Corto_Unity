using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class MenuPrincipal : MonoBehaviour, ICambioEscena
{
    string nivel;
    public GameObject botonContinuar;
    public GameObject panelMenuPrincipal;
    public GameObject panelNiveles;
    public GameObject btNivel1;
    public GameObject btNivel2;
    public GameObject btNivel3;
    

    void crearTexto()
    {
        String archivo = Application.dataPath + "/nivel.txt";

        if (!File.Exists(archivo))
        {
            File.WriteAllText(archivo, "0");
        }
        else
        {
            nivel = File.ReadAllText(archivo);
        }
    }

    void Start()
    {
        crearTexto();
        if (nivel.Equals("0"))
        {
            botonContinuar.SetActive(false);
        }
        else
        {
            botonContinuar.SetActive(true);
        }
    }

    public void cambiarEscena()
    {
        SceneManager.LoadScene(2);
    }

    public void regresarInicioSeccion()
    {
        //Para salir del juego
        SceneManager.LoadScene(0);
    }
    
    public void continuar()
    {
        panelNiveles.SetActive(true);
        panelMenuPrincipal.SetActive(false);
        if (nivel.Equals("1"))
        {
            btNivel1.SetActive(true);
            btNivel2.SetActive(false);
            btNivel3.SetActive(false);
        }
        else if (nivel.Equals("2"))
        {
            btNivel1.SetActive(true);
            btNivel2.SetActive(true);
            btNivel3.SetActive(false);
        }
        else if (nivel.Equals("3"))
        {
            btNivel1.SetActive(true);
            btNivel2.SetActive(true);
            btNivel3.SetActive(true);
        }
    }

    public void regresarMP()
    {
        panelNiveles.SetActive(false);
        panelMenuPrincipal.SetActive(true);
    }

    public void pesionaBtNivel1()
    {
        SceneManager.LoadScene(2);
    }

    public void pesionaBtNivel2()
    {
        SceneManager.LoadScene(3);
    }

    public void pesionaBtNivel3()
    {
        SceneManager.LoadScene(4);
    }
}
