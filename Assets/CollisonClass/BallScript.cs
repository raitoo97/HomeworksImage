using System;
using UnityEngine;
public class BallScript : MonoBehaviour
{
    public Action<GameObject> Notify;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            this.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Notify.Invoke(gameObject);
    }
    private void OnEnable()
    {
        
    }
}
