using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planta_Enemy : MonoBehaviour
{
    private float tiempodeespera;
    private float tiempodeesperalimite = 3;

    public Animator animator;
    public GameObject bullet;
    public Transform punto_Lanzamiento;

    private void Start()
    {
        tiempodeespera = tiempodeesperalimite;
    }
    private void Update()
    {
        if (tiempodeespera <= 0)
        {
            tiempodeespera = tiempodeesperalimite;
            animator.Play("attack");
            Invoke("Lanzarbala", 0.5f);
        }
        else
        {
            tiempodeespera -= Time.deltaTime;
        }
    }
    private void Lanzarbala()
    {
        GameObject nuevabala;
        nuevabala = Instantiate(bullet,punto_Lanzamiento.position, punto_Lanzamiento.rotation);
    }
}
