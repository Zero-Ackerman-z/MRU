using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla_Lineal : MonoBehaviour
{
    public Transform[] puntosDePatrulla;
    public float velocidad = 5.0f;
    private int puntoActual = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (puntosDePatrulla.Length == 0) return;

        Vector3 direccion = (puntosDePatrulla[puntoActual].position - transform.position).normalized;
        rb.velocity = direccion * velocidad;

        if (Vector3.Distance(transform.position, puntosDePatrulla[puntoActual].position) < 0.1f)
        {
            puntoActual = (puntoActual + 1) % puntosDePatrulla.Length;
        }
    }
}

