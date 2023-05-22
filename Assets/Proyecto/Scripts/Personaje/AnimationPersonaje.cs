using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPersonaje: MonoBehaviour
{
    public float SpeedMov;
    public float SpeedRotation;

    private Animator Animacion;
    public float x, y;

    public Rigidbody rb;
    public float FuerzaSalto = 8f;
    public bool PuedoSaltar ;


    
    

    // Start is called before the first frame update
    void Start()
    {
        PuedoSaltar = false;
        Animacion=  GetComponent<Animator>();
    }

     void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * SpeedRotation, 0);
        transform.Translate(0, 0, y * Time.deltaTime * SpeedMov);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");




        Animacion.SetFloat("VelX", x);
        Animacion.SetFloat("VelY", y);

        if(PuedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Animacion.SetBool("Salte", true);
                rb.AddForce(new Vector3(0, FuerzaSalto, 0), ForceMode.Impulse);
                PuedoSaltar = false;
            }
            Animacion.SetBool("TocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }

        

    }

    public void EstoyCayendo()
    {
        Animacion.SetBool("Salte", false);
        Animacion.SetBool("TocoSuelo", false);
    }

    
}
