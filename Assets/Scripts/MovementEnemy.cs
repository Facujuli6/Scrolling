using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
   
    private float velocidadX = 1.5f;
        
    private float velocidadY = -1.2f;
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, 0);

        if ((transform.position.x <-3) || (transform.position.x >3))
                
                velocidadX = -velocidadX;

        if ((transform.position.y < -2) || (transform.position.y > 12))                    
                
                velocidadY =-velocidadY;
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player1"))
        {
            GameManager.Instance.Derrota();
            Destroy (collision.gameObject);
            Destroy(gameObject);
        }
    }
}
