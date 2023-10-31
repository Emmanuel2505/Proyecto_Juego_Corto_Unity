using System;
using UnityEngine;

public abstract class LogicaObjetosEscenarios : MonoBehaviour
{

    public Rigidbody plataforma;
    public Transform[] posicionesPlataforma;
    public float velocidadPlataforma;

    public int posicionActual = 0;
    public int posicionSiguiente = 1;

    public virtual void moverObjeto()
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

    public virtual void destruirObjeto()
    {
        try
        {
            Destroy(this.gameObject);
        }
        catch (NullReferenceException)
        {
            Debug.Log("No Existe el objeto");
        }
    }


}
