using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brains : MonoBehaviour
{
    // Start is called before the first frame update
    Vehicle vehicle;

    void Start()
    {
        vehicle = GetComponent<Vehicle>();
    }
    void Update()
    {
        var dir = Mathf.PerlinNoise1D(Time.time) * 2 - 1;
        vehicle.Turn(dir);
        vehicle.Accelarate();
    }
}
