using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private float velocidadY = 2.5f;
    private float velocidadx = 3.5f;
    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(0, vertical * velocidadY * Time.deltaTime, 0);
        if ((transform.position.x < -3f) || (transform.position.x > 3f))

            velocidadx = -velocidadx;
        if ((transform.position.y < -3f) || (transform.position.y > 27f))
       
            velocidadY = -velocidadY;


    }
}

