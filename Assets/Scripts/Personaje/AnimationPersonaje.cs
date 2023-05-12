using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPersonaje: MonoBehaviour
{
    public float SpeedMov;
    public float SpeedRotation;
    private Animator Animacion;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
      Animacion=  GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");


        transform.Rotate(0, x * Time.deltaTime * SpeedRotation, 0);
        transform.Translate(0, 0, y * Time.deltaTime * SpeedMov);

        Animacion.SetFloat("VelX", x);
        Animacion.SetFloat("VelY", y);
    }
}
