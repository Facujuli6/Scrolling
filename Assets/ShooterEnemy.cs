using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShooterEnemy : MonoBehaviour
{

    private float velocidadDisparo = -1;
    [SerializeField] Transform prefabDisparo = null;
    void Start()
    {
        StartCoroutine(Disparar());
    }

    IEnumerator Disparar()
    {
        float pausa = Random.Range (3,7f);
        yield return new WaitForSeconds(pausa);
        Transform disparo = Instantiate(prefabDisparo, transform.position,Quaternion.identity);
        disparo.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3 (0, velocidadDisparo, 0);
        StartCoroutine (Disparar());       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player1"))
        {
            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
        
    }
}
