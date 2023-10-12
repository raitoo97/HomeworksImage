using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public LayerMask mask;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray rayo = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        //RaycastHit hit;
        //if(Physics.Raycast(rayo.origin, rayo.direction,out hit,50.0f))
        //{
        //    print(hit.transform.gameObject.name);
        //}
        RaycastHit[] hits;
        hits = Physics.RaycastAll(rayo.origin, rayo.direction, 50.0f, mask);
        Debug.DrawRay(rayo.origin, rayo.direction * 50.0f, Color.blue);
        if (hits != null)
        {
            foreach(var hite in hits)
            {
                Debug.Log(hite.collider.name);
            }
        }
    }
}
