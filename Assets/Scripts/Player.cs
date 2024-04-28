using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vehicle vehicle;
    private void Start()
    {
        vehicle = GetComponent<Vehicle>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            vehicle.Accelarate();
        }
        if (Input.GetKey(KeyCode.S))
        {
            vehicle.Brake();
        }
        var horInput = Input.GetAxis("Horizontal");
        if (horInput != 0)
        {
            vehicle.Turn(horInput);
        }
    }
}
