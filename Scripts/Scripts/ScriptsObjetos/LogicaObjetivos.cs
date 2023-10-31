using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class LogicaObjetivos : MonoBehaviour
{
    public int numeroObjetivos;
    public TMP_Text textoMision;
    public string etiquetaObjetivo;
    public bool correcto = false;
    // Start is called before the first frame update


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numeroObjetivos = GameObject.FindGameObjectsWithTag(etiquetaObjetivo).Length;
        textoMision.text = "" + numeroObjetivos;
    }

    private void OnTriggerEnter(Collider colisionObjeto)
    {
        if (colisionObjeto.gameObject.tag == etiquetaObjetivo)
        {
            Destroy(colisionObjeto.transform.parent.gameObject);
            numeroObjetivos = numeroObjetivos - 1;
            textoMision.text = "" + numeroObjetivos;

            if (numeroObjetivos == 0)
            {
                this.correcto = true;
            }
        }
    }

    public bool getCorrecto()
    {
        return correcto;
    }

    public void setCorrecto(bool correcto)
    {
        this.correcto = correcto;
    }
}
