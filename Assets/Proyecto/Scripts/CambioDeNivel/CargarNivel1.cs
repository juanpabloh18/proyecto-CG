 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarNivel1 : MonoBehaviour
{
    // Funci�n p�blica que se llama al presionar el bot�n "jugar"
    public void jugar()
    {
        // Obtiene el �ndice de la escena actual y carga la siguiente escena en la lista de escenas
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
