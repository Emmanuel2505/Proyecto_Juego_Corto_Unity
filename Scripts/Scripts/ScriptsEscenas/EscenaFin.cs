
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaFin : MonoBehaviour
{
    float tiempoDeVida = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDeVida -= Time.deltaTime;
        if (tiempoDeVida <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
