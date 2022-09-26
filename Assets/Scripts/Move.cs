using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed = 50f;
    
    private Rigidbody _rb;
    
    


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        MovementLogic();
    }

    private void MovementLogic()
    {
        var moveHorizontal = 0f;
        var moveVertical = 0f;
        if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
        { 
                 
           moveHorizontal = -Input.GetAxis("Horizontal");
           moveVertical = -Input.GetAxis("Vertical");
        }
        
        if (Application.platform == RuntimePlatform.Android)
        {
            EnabledGiro();
            moveHorizontal = -Input.acceleration.x;
            moveVertical = -Input.acceleration.y;

        }

        // Перемещение шара
        var movement = new Vector3(moveHorizontal, 0, moveVertical);
        _rb.AddForce(movement * Speed);
    }

    private void EnabledGiro()
    {
        if (!SystemInfo.supportsGyroscope)
        {
            Application.Quit();
        }

        Input.gyro.enabled = true;
    }
    

    
}

