using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorPuntos : MonoBehaviour
{
    public static ContadorPuntos instance; // Instancia única de la clase para asegurar que solo haya una instancia en ejecución
    public int puntos = 0;// Variable que almacena los puntos del jugador
    public Text puntosText; //Referencia al objeto de tipo Text que mostrará los puntos en pantalla




    // Este método se llama cuando se crea el objeto en el juego
    void Awake()
    {
        // Borrar cualquier información guardada anteriormente
        PlayerPrefs.DeleteAll();

        // Si no hay una instancia de la clase, la asignamos a la variable 'instance'
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Evitamos que el objeto se destruya al cambiar de escena
        }
        else
        {
            Destroy(gameObject);  // Destruimos el objeto para evitar que haya más de una instancia
        }
    }

    // Este método se llama al inicio del juego
    void Start()
    {
        // Recuperar la información guardada de los puntos y actualizar el objeto de texto en pantalla
        puntos = PlayerPrefs.GetInt("puntos", 0);
        puntosText.text = puntos.ToString();
    }

    // Este método se llama en cada frame
    void Update()
    {

    }

    // Este método permite agregar una cantidad de puntos al contador
    public void AgregarPuntos(int cantidad)
    {
        // Aumentar la variable de puntos y actualizar el objeto de texto en pantalla
        puntos += cantidad;
        puntosText.text = puntos.ToString();

        // Guardar la información de los puntos en el almacenamiento local del dispositivo
        PlayerPrefs.SetInt("puntos", puntos);
    }

}