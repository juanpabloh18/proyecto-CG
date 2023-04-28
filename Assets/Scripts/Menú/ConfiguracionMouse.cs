using UnityEngine;
using UnityEngine.UI;


public class ConfiguracionMouse : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        float valorSlider = PlayerPrefs.GetFloat("ConfiguracionMouse", 1f);
        slider.value = valorSlider;
        ConfigurarMouse(valorSlider);
    }

    public void CambiarConfiguracion(float valor)
    {
        // Guarda el valor del slider en PlayerPrefs
        PlayerPrefs.SetFloat("ConfiguracionMouse", valor);

        // Configura la sensibilidad del mouse en base al valor del slider
        ConfigurarMouse(valor);
    }

    private void ConfigurarMouse(float valor)
    {
        // Configura la sensibilidad del mouse en base al valor del slider
        // Este es solo un ejemplo, deberías ajustar esto a tus propias necesidades
        float sensibilidad = valor * 5f;
        MouseLook[] controlesMouse = FindObjectsOfType<MouseLook>();
        foreach (MouseLook controlMouse in controlesMouse)
        {
            controlMouse.sensitivity = sensibilidad;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
