using UnityEngine;
public class RayCast : MonoBehaviour
{
    public LayerMask mask;
    private float distance;
    private void Start()
    {
        distance = 50.0f;
    }
    void Update()
    {
        UsingRay();
    }
    public void UsingRay()
    {
        Ray rayo_rojo = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(rayo_rojo.origin, rayo_rojo.direction * distance, Color.red);
    }
}
