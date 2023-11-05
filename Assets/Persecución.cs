using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecución : MonoBehaviour
{
    public Transform puntoOpuesto;
    public Transform jugador;
    public float velocidadInicial = 5.0f;
    public float aceleracion = 2.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (puntoOpuesto != null && jugador != null)
        {
            Vector3 direccion = (puntoOpuesto.position - transform.position).normalized;
            rb.velocity = direccion * velocidadInicial;
        }
    }

    void FixedUpdate()
    {
        if (puntoOpuesto != null && jugador != null)
        {
            Vector3 direccion = (puntoOpuesto.position - transform.position).normalized;
            rb.velocity += direccion * aceleracion * Time.fixedDeltaTime;
        }
    }
}

