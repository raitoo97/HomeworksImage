using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    private Rigidbody rb;
    public int force;
    public Action<List <GameObject>> forceAction;
    public List <GameObject> forceGameObject;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        var TempList = new List<Rigidbody>(GameObject.FindObjectsOfType<Rigidbody>());
        foreach (var Temp in TempList)
        {
            forceGameObject.Add(Temp.gameObject);
        }
        print(forceGameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(shoot());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        print("Colisioooon!!!!!!!");
        forceAction.Invoke(forceGameObject);
    }
    IEnumerator shoot()
    {
        yield return new WaitForFixedUpdate();
        rb.AddForce(Vector3.forward * force, ForceMode.VelocityChange);
        //rb.velocity = Vector3.forward * force;
    }
}
