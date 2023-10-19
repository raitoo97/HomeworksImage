using UnityEngine;
public class ShootSphere : MonoBehaviour
{
    [SerializeField] private MovePj pj;
    private int force;
    private void Awake()
    {
        force = 20;
    }
    void Start()
    {
        pj = GameObject.FindObjectOfType<MovePj>();
        pj.active_ray += Shoot;
    }
    private void Shoot()
    {
        var go = PoolBalls.instance.ReturnBall();
        if (go == null) return;
        go.transform.position = this.transform.position;
        go.transform.rotation = this.transform.rotation;
        if (go.GetComponent<Rigidbody>() == null) return;
        go.GetComponent<Rigidbody>().AddForce(this.transform.forward * force, ForceMode.Impulse);
    }
}
