using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEst : MonoBehaviour
{
    private Rigidbody rb;
    private Coroutine coroutine;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            coroutine = StartCoroutine(StartCor());
        }
    }
    IEnumerator StartCor()
    {
        yield return new WaitForFixedUpdate();
        rb.AddForce(Vector3.up * 3, ForceMode.VelocityChange);
        rb.AddForce(Vector3.forward * 3, ForceMode.VelocityChange);
        rb.useGravity = false;
        Debug.Log("Vieja");
    }
}
