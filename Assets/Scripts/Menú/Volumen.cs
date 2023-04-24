using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider Slider;
    public float Slidervalue;
    public Image ImagenMute;


    // Start is called before the first frame update
    void Start()
    {
        Slider.value = PlayerPrefs.GetFloat("VolumenAudio", 0.5f);
        AudioListener.volume = Slider.value;
        RevisarSiEstaMute();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarSlider(float valor)
    {
        Slidervalue = valor;
        PlayerPrefs.SetFloat("VolumenAudio", Slidervalue);
        AudioListener.volume = Slider.value;
        RevisarSiEstaMute();

    }

    public void RevisarSiEstaMute()
    {
        if (Slidervalue == 0)
        {
            ImagenMute.enabled = true;  
        }
        else
        {
            ImagenMute.enabled = false;
        }
    }
}
