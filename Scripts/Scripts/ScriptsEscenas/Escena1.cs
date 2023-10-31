
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.IO;

public class Escena1 : MonoBehaviour
{
    bool correctoRojo = false;
    public Esfera esfera;
    float tiempoDeVida = 2f;
    string nivel;
    



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        String archivo = Application.dataPath + "/nivel.txt";

        if (!File.Exists(archivo))
        {
            File.WriteAllText(archivo, "1");
        }
        else
        {
            
            nivel = File.ReadAllText(archivo);
            if (!nivel.Equals("2") && !nivel.Equals("3"))
            {
                File.WriteAllText(archivo, "1");
            }
        }
        this.correctoRojo = esfera.getCorrecto();
        if (correctoRojo)
        {

            esfera.escribirTexto();
            tiempoDeVida -= Time.deltaTime;
            if (tiempoDeVida <= 0)
            {
                File.WriteAllText(archivo, "2");
                SceneManager.LoadScene(3);
            }
        }
    }


}
