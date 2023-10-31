using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IMover
{
    public float velocidadMovimiento = 3.0f;
    public float velociadRotacion = 200.0f;
    private Animator anim;
    public float x, y;
    public Rigidbody rb;
    public float fuerzaSalto = 8f;
    public bool puedoSaltar;

    public float velocidadInicial;
    public float velocidadAgachado;

    public CapsuleCollider parado;
    public CapsuleCollider agachado;
    public GameObject cabeza;
    public LogicaCabeza logicaCabeza;
    public bool estaAgachado;

    // Start is called before the first frame update
    void Start()
    {
        puedoSaltar = false;
        anim = GetComponent<Animator>();
        velocidadInicial = velocidadMovimiento;
        velocidadAgachado = velocidadMovimiento * 0.5f;
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velociadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }

    // Update is called once per frame
    void Update()
    {
        mover();
    }


    public void mover()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
       
        anim.SetFloat("VelocidadX", x);
        anim.SetFloat("VelocidadY", y);

        if (puedoSaltar)
        {           
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Salto", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.LeftControl))
            {
                anim.SetBool("Agachar", true);
                velocidadMovimiento = velocidadAgachado;
                agachado.enabled = true;
                parado.enabled = false;
                cabeza.SetActive(true);
                estaAgachado = true;
            }
            else
            {
                if (logicaCabeza.contador <= 0)
                {
                    anim.SetBool("Agachar", false);
                    velocidadMovimiento = velocidadInicial;
                    agachado.enabled = false;
                    parado.enabled = true;
                    cabeza.SetActive(false);
                    estaAgachado = false;
                }
                if (Input.GetKey(KeyCode.RightControl))
                {
                    anim.SetBool("Agachar", false);
                    velocidadMovimiento = velocidadInicial;
                    agachado.enabled = false;
                    parado.enabled = true;
                    cabeza.SetActive(false);
                    estaAgachado = false;
                }
            }
            anim.SetBool("TocarSuelo", true);
        }
        else
        {

            caer();
        }
    }

    public void caer()
    {
        anim.SetBool("TocarSuelo", false);
        anim.SetBool("Salto", false);
    }

    

    
}
