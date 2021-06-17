using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntecifeir : MonoBehaviour
{
    Light myLight;
    public float speed;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        myLight.intensity = Mathf.Lerp(0, 100, speed);

    }
}
