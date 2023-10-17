using UnityEngine;
public class RayCast : MonoBehaviour
{
    public LayerMask mask;
    private float distance;
    private MovePj pj_ref;
    private void Start()
    {
        distance = 50.0f;
        pj_ref = GameObject.FindObjectOfType<MovePj>();
        pj_ref.active_ray += UsingRay;
    }
    void Update()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);
    }
    public void UsingRay()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray.origin, ray.direction, out hit, distance, mask))
        {
            Debug.Log(hit.transform.gameObject.transform);
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);
        }
    }
}
