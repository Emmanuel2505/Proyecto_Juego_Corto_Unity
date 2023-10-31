using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Esfera : LogicaObjetivos
{
    string textoEsfera;
    public TMP_Text textoPanel;
    float tiempoDeVida = 2f;

    public Esfera()
    {
        this.textoEsfera = "Objetivos Rojos Completados";
    }

    public void escribirTexto()
    {
        textoPanel.text = textoEsfera;
        tiempoDeVida -= Time.deltaTime;
        if (tiempoDeVida <= 0)
        {
            this.textoEsfera = "";
        }
    }
}
