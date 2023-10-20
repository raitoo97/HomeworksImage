using UnityEngine;
public class RayCast : MonoBehaviour
{
    public LayerMask mask;
    private float distance;
    public Material yellow;
    public Material Green;
    private void Start()
    {
        distance = 50.0f;
        var find_targets = FindObjectsOfType<CubeScript>();
        foreach (var target in find_targets)
        {
            target.gameObject.GetComponent<Renderer>().material = yellow;
        }
    }
    void Update()
    {
        UsingRay();
    }
    public void UsingRay()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);
        if(Physics.Raycast(ray.origin,ray.direction,out hit, distance, mask))
        {
            if(hit.transform.gameObject.GetComponent<Rigidbody>() == null)return;
            var hit_target_rb = hit.transform.gameObject.GetComponent<Rigidbody>();
            if (hit_target_rb.useGravity)
            {
                hit_target_rb.gameObject.GetComponent<Renderer>().material = yellow;
            }
            else
            {
                hit_target_rb.gameObject.GetComponent<Renderer>().material = Green;
            }
        }
    }
}
