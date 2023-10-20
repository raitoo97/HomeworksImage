using UnityEngine;
public class BallScript : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke("Desativate", 10.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var local_collision = collision.gameObject.GetComponent<Rigidbody>();
        if (local_collision == null) return;
        if (!local_collision.useGravity)
        {
            local_collision.useGravity = true;
            Desativate();
        }
        else if(local_collision.useGravity)
        {
            local_collision.useGravity = false;
            Desativate();
        }
    }
    private void Desativate()
    {
        this.gameObject.SetActive(false);
    }
}
