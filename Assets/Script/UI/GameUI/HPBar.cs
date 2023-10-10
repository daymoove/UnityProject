using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HPBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    

    public void UpdateHPSlider(int current, int target)
    {
        slider.maxValue = target;
        slider.value = current;
    }


}
