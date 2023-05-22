using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//*@author juan_pablo.hurtado @uao.edu.co Juan Pablo Hurtado C�digo: 2210904
// * @author dayan.lara @uao.edu.co Dayan David Lara Calzada C�digo: 2190678
// * @author David_ale.perez @uao.edu.co David Alejandro Perez Montoya C�digo: 2201374
// * @author Jesus_alejandro.gil @uao.edu.co Jesus Alejandro Gil C�digo: 2201375
// * @date 31�Marzo 2023

public class ColliderBarril : MonoBehaviour
{
    public GameObject Barril; // Referencia al objeto del barril que se va a destruir
    public ContadorPuntos contadorPuntos; // Referencia al componente que lleva el registro de la puntuaci�n

    void Start()
    {
        contadorPuntos = FindObjectOfType<ContadorPuntos>();  // Buscamos el componente ContadorPuntos en el juego
    }

    void Update()
    {

    }

    // Este m�todo se llama cuando el jugador entra en contacto con el objeto asociado a este collider
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))  // Si el objeto que colisiona tiene el tag "Player"
        {
            if (Barril != null)  // Si la referencia al objeto del barril no es nula
            {
                contadorPuntos.AgregarPuntos(1);  // Llamamos al m�todo AgregarPuntos de la clase ContadorPuntos para incrementar la puntuaci�n en 1
                Destroy(Barril);  // Destruimos el objeto del barril
            }
        }
    }

}









