using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public AnimationPersonaje animationPersonaje;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //animationPersonaje.PuedoSaltar = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("suelo"))
        {
            animationPersonaje.PuedoSaltar = true;
            
        }
        
        //animationPersonaje.PuedoSaltar = true;
        //Debug.Log("entre");
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("suelo"))
        {
            animationPersonaje.PuedoSaltar = false;
            
        }

    }
}
