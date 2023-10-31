using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjetoPlataforma : LogicaObjetosEscenarios
{

    public Rigidbody jugador;
    void Update()
    {
        moverObjeto();
    }

    public override void moverObjeto()
    {
        plataforma.MovePosition(Vector3.MoveTowards(plataforma.position, posicionesPlataforma[posicionSiguiente].position, velocidadPlataforma * Time.deltaTime));
        if (Vector3.Distance(plataforma.position, posicionesPlataforma[posicionSiguiente].position) <= 0)
        {
            posicionActual = posicionSiguiente;
            posicionSiguiente++;

            if (posicionSiguiente > posicionesPlataforma.Length - 1)
            {
                posicionSiguiente = 0;
            }
        }
    }

}
