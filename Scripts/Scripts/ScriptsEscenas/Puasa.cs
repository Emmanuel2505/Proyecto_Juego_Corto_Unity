using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puasa : MonoBehaviour
{
    public GameObject panelPausa;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausar();
        }
    }

    public void pausar()
    {
        if(Time.timeScale == 1)
        {
            Time.timeScale = 0;
            panelPausa.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            panelPausa.SetActive(false);
        }
    }

    public void salirAlInicio()
    {
        SceneManager.LoadScene(1);
    }
}
