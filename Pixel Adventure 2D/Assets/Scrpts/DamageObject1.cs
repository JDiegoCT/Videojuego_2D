using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Existe Colision");
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Daño Realizado");
            Destroy(collision.gameObject);
        }
    }
}
