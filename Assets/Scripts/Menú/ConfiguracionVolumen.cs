using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfiguracionVolumen : MonoBehaviour
{
    public Slider Slider;
    public float SliderValue;
    
    // Start is called before the first frame update
    void Start()
    {
        Slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.0f);
        AudioListener.volume = Slider.value;
        

        Debug.Log(PlayerPrefs.GetFloat("volumenAudio", 0.0f));
    }


    public void CambiarSlider(float valor)
    {
        PlayerPrefs.SetFloat("volumenAudio", valor);
        AudioListener.volume = valor;
       
    }


   
   




}