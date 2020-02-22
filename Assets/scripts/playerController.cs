using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    controls controlsVariables;
    private playerMovements movements;
    private Vector3 direction;
    public float speed;

    void Start()
    {
        movements = GetComponent<playerMovements>();
        speed = 20f;
        direction = Vector3.zero;
        controlsVariables = GetComponent<controls>();
    }

    void Update()
    {
        
        if (Input.GetKey(controlsVariables.avancer))
        {
            direction = direction + new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(controlsVariables.reculer))
        {
            direction = direction + new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(controlsVariables.droite))
        {
            direction = direction + new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(controlsVariables.gauche))
        {
            direction = direction + new Vector3(0, 0, speed);
        }
        movements.Move(direction);
        direction = Vector3.zero;
        
    }
}
