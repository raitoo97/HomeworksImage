using System.Collections;
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
        pj.active_ray += ShootFunction;
    }
    private void ShootFunction()
    {
        StartCoroutine(Shoot());
    }
    
    IEnumerator Shoot()
    {
        yield return new WaitForFixedUpdate();
        var go = PoolBalls.instance.ReturnBall();
        go.transform.position = this.transform.position;
        go.transform.rotation = this.transform.rotation;
        go.GetComponent<Rigidbody>().AddForce(this.transform.forward * force, ForceMode.Impulse);
    }
}
