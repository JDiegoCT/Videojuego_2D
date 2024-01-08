using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Damage : MonoBehaviour
{
    public float speed = 2;
    public float lifetime = 2;
    public bool izquierda;
    
    private void Start()
    {
        Destroy(gameObject, 2);
    }
    private void Update()
    {
        if (izquierda)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
