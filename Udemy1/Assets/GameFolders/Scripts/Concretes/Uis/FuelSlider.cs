using System.Collections;
using System.Collections.Generic;
using Udemy1.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace Udemy1.Uis
{
    public class FuelSlider : MonoBehaviour
    {
        Slider _slider;
        Fuel _fuel;
        private void Awake()
        {
                _slider = GetComponent<Slider>();   
                _fuel = FindAnyObjectByType<Fuel>();
        }
        private void Update()
        {
            _slider.value = _fuel.CurrentFuel;
        }
    }

}
