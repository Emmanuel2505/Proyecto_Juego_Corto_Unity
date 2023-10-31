using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerObjeto : LogicaObjetosEscenarios
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public override void destruirObjeto()
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
