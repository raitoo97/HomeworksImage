using UnityEngine;
public class BallScript : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Desativate", 5.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var local_collision = collision.gameObject.GetComponent<Rigidbody>();
        if (local_collision == null) return;
        if (!local_collision.useGravity)
        {
            local_collision.useGravity = true;
        }
        else if(local_collision.useGravity)
        {
            local_collision.useGravity = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
        {
            Desativate();
        }
    }
    private void Desativate()
    {
        this.gameObject.SetActive(false);
    }
}
