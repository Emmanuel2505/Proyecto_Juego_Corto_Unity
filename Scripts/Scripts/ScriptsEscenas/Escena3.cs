using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Escena3 : MonoBehaviour
{
    public DesaparecerObjeto desaparecer;
    bool correctoAzul = false;
    bool correctoRojo = false;
    bool correctoAmarillo = false;
    public Esfera esfera;
    public Capsula capsula;
    public Cilindros cilindro;
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
            File.WriteAllText(archivo, "3");
        }
        else
        {
            nivel = File.ReadAllText(archivo);
        }
        this.correctoRojo = esfera.getCorrecto();
        if (correctoRojo)
        {
            this.correctoAzul = capsula.getCorrecto();

            if (correctoAzul)
            {
                this.correctoAmarillo = cilindro.getCorrecto();
                capsula.escribirTexto();
                if (correctoAmarillo)
                {
                    cilindro.escribirTexto();
                    if (correctoRojo && correctoAzul)
                    {
                        tiempoDeVida -= Time.deltaTime;
                        if (tiempoDeVida <= 0)
                        {
                            SceneManager.LoadScene(5);
                        }
                    }
                }
            }
            esfera.escribirTexto();
            desaparecer.destruirObjeto();

        }
    }
}

