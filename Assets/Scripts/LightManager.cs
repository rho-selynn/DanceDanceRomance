using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    private Light myLight;


    void Start()
    {
        myLight = GetComponent<Light>();
    }


    public void Toggle()
    {
        myLight.enabled = !myLight.enabled;
    }
}
