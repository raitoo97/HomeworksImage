using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float force;
    public Rigidbody body;
    public Transform go;
    private Rigidbody rb;
    public ForceMode mode;
    private Coroutine coroutine;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartLanzar();
        }
        if (Input.GetMouseButtonDown(1))
        {
            StopLanzar();
        }
    }
    public void StartLanzar()
    {
        coroutine = StartCoroutine(lanzar());
        Debug.Log("Hola");
    }
    public void StopLanzar()
    {
        StopCoroutine(coroutine);
        Debug.Log("Chau");
    }

    IEnumerator lanzar()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            Vector3 dif = go.position - this.transform.position;
            rb.AddForce(dif.normalized * force, mode);
        }
    }
}
