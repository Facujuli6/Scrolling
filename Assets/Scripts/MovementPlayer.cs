using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementPlayer : MonoBehaviour


{
    
    [SerializeField] Transform prefabDisparo;
    private float velocidadx = 4;
    private float velocidady = 2.5f;
    [SerializeField] float velocidadDisparo = 2;
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(horizontal * velocidadx * Time.deltaTime, 0, 0);
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(0, vertical * velocidady * Time.deltaTime, 0);

        if ((transform.position.x < -3f) || (transform.position.x > 3f))

            velocidadx = -velocidadx;

        //if ((transform.position.y < -4.5f) || (transform.position.y > 4.5f))

        // velocidady = -velocidady;

        if (Input.GetButtonDown("Fire1"))
        {
            Transform disparo = Instantiate(prefabDisparo, transform.position, Quaternion.identity);
            disparo.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, velocidadDisparo, 0);
        }
    }
}
   
