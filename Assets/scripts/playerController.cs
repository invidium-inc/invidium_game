using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    controls controlsVariables;
    private playerMovements movements;
    private Vector3 direction;
    public Joystick movementJoystick;
    public Joystick cameraJoystick;
    public float speed;
    public float cameraSpeed;
    public GameObject MainCamera;
    Vector3 rotationPlayer;
    Vector3 rotationCamera;

    void Start()
    {
        movements = GetComponent<playerMovements>();
        speed = 20f;
        direction = Vector3.zero;
        controlsVariables = GetComponent<controls>();
    }

    void Update()
    {
        float Vertical = movementJoystick.Vertical;
        float Horizontal = movementJoystick.Horizontal;
        float VerticalCamera = cameraJoystick.Vertical;
        float HorizontalCamera = cameraJoystick.Horizontal;
        direction = new Vector3(Vertical * speed, 0, -Horizontal * speed);
        rotationPlayer = new Vector3(0, HorizontalCamera * cameraSpeed, 0);
        rotationCamera = new Vector3(-VerticalCamera * cameraSpeed,0,0);

        transform.Rotate(rotationPlayer);
        MainCamera.transform.Rotate(rotationCamera);

        /*
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
        }*/
        movements.Move(direction);
        direction = Vector3.zero;
        



    }
}
