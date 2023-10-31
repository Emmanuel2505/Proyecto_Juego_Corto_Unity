using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cilindros : LogicaObjetivos
{
    string textoCilindro;
    public TMP_Text textoPanel;
    float tiempoDeVida = 2f;

    public Cilindros()
    {
        this.textoCilindro = "Objetivos Amarillos Completados";
    }

    public void escribirTexto()
    {
        textoPanel.text = textoCilindro;
        tiempoDeVida -= Time.deltaTime;
        if (tiempoDeVida <= 0)
        {
            this.textoCilindro = "";
        }
    }
}
