using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public Text timerMinutes; // Texto para mostrar los minutos
    public Text timerSeconds; // Texto para mostrar los segundos
    public Text timerSeconds100; // Texto para mostrar los segundos centésimas


    public float startTime; // Tiempo de inicio del temporizador
    public float stopTime; // Tiempo de parada del temporizador
    public float timerTime; // Tiempo actual del temporizador
    public bool isRunning = false; // Indica si el temporizador está corriendo o no
    public bool isSummaryScene = false; // Indica si la escena actual es la de resumen
    public string finTime = ""; // Tiempo final del temporizador en formato de cadena


    public int minutesInt, secondsInt, seconds100Int;

    // Use this for initialization
    void Start()
    {
        TimerStart(); // Iniciar el temporizador
        Scene currentScene = SceneManager.GetActiveScene(); // Obtener la escena actual
    }


    void Update()
    {
        // Si la escena actual no es la de resumen
        if (!isSummaryScene)
        {
            // Calcular el tiempo actual
            timerTime = stopTime + (Time.time - startTime);
            // Convertir el tiempo actual a minutos, segundos y centésimas
            minutesInt = (int)timerTime / 60;
            secondsInt = (int)timerTime % 60;
            seconds100Int = (int)(Mathf.Floor((timerTime - (secondsInt + minutesInt * 60)) * 100));

            // Si el temporizador está corriendo
            if (isRunning)
            {
                // Mostrar los minutos, segundos y centésimas en los textos correspondientes
                if (timerMinutes != null && timerSeconds != null && timerSeconds100 != null)
                {
                    timerMinutes.text = (minutesInt < 10) ? "0" + minutesInt : minutesInt.ToString();
                    timerSeconds.text = (secondsInt < 10) ? "0" + secondsInt : secondsInt.ToString();
                    timerSeconds100.text = (seconds100Int < 10) ? "0" + seconds100Int : seconds100Int.ToString();
                }
            }
        }
        else // Si la escena actual es la de resumen
        {
            TimerStop(); // Detener el temporizador
        }
    }

    public void TimerStart()
    {
        // Si el temporizador no está corriendo
        if (!isRunning)
        {
            print("START");
            isRunning = true; // Establecer que el temporizador está corriendo
            startTime = Time.time; // Guardar el tiempo actual como tiempo de inicio
        }
    }
    
    // Método para detener el temporizador 
    public void TimerStop()
    {
        // Detiene el temporizador si se está ejecutando
        if (isRunning)
        {
            isRunning = false;   // Cambia la variable isRunning a false para indicar que el temporizador está detenido
            print("STOP");
            isRunning = false;
            // Guardar el tiempo actual como tiempo de par
            Debug.Log(secondsInt); // Debug.Log muestra el número de segundos actuales en la consola
        }
    }

    public void TimerReset()
    {
        // Resetea el temporizador estableciendo stopTime a 0, cambiando la variable isRunning a false
        // y mostrando "00" en los Textos del temporizador
        stopTime = 0;
        isRunning = false;
        timerMinutes.text = timerSeconds.text = timerSeconds100.text = "00";
    }


    public void detener()
    {
        // Cambia la variable isSummaryScene a true para indicar que se ha llegado a la escena final
        isSummaryScene = true;
    }

}
