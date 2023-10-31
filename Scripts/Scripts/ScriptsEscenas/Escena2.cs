using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Escena2 : MonoBehaviour
{
    public DesaparecerObjeto desaparecer;
    bool correctoAzul = false;
    bool correctoRojo = false;
    public Esfera esfera;
    public Capsula capsula;
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
            File.WriteAllText(archivo, "2");
        }
        else
        {
            nivel = File.ReadAllText(archivo);
            if (!nivel.Equals("3"))
            {
                File.WriteAllText(archivo, "2");
            }
        }
        this.correctoRojo = esfera.getCorrecto();
        if (correctoRojo)
        {
            this.correctoAzul = capsula.getCorrecto();

            if (correctoAzul)
            {
                
                capsula.escribirTexto();
                if(correctoRojo && correctoAzul)
                {
                    tiempoDeVida -= Time.deltaTime;
                    if (tiempoDeVida <= 0)
                    {
                        File.WriteAllText(archivo, "3");
                        SceneManager.LoadScene(4);
                    }
                }
            }
            esfera.escribirTexto();
            desaparecer.destruirObjeto();
            
        }  
    }
}
