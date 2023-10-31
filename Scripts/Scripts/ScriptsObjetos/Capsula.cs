using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Capsula : LogicaObjetivos
{
    string textoCapsula;
    public TMP_Text textoPanel;
    float tiempoDeVida = 2f;

    public Capsula()
    {
        this.textoCapsula = "Objetivos Azules Completados";
    }

    public void escribirTexto()
    {
        textoPanel.text = textoCapsula;
        tiempoDeVida -= Time.deltaTime;
        if (tiempoDeVida <= 0)
        {
            this.textoCapsula = "";
        }
        Debug.Log(textoCapsula);
    }
}
