using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform prefabExplosion;

    void Update()
    {
     
        if (transform.position.y > 40)
        {
          Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.tag == "Enemigo")
        {
            Transform explosion = Instantiate(prefabExplosion, otro.transform.position, Quaternion.identity);
            Destroy (otro.gameObject);
            Destroy (explosion.gameObject, 1.5f);
            Destroy (gameObject);
        }
    }
}
