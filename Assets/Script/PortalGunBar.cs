
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalGunBar : MonoBehaviour
{
    public Slider slider;
    // public Gradient gradient;
    public Image Fill;
    
    public void SetMaxGunPower(int power){
        slider.maxValue = power;
        slider.value = power;

        // Fill.color = gradient.Evaluate(1);
    }

    public void SetGunPower(int power){
        slider.value = power;

        // fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
