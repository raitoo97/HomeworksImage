using UnityEngine;
public class FollowPj : MonoBehaviour
{
    [SerializeField] private Transform Pj;
    private Camera camera;
    void Start()
    {
        Pj = GameObject.FindObjectOfType<MoveSphere>().GetComponent<Transform>();
        camera = this.GetComponent<Camera>();
    }
    private void Update()
    {
        this.transform.LookAt(Pj);
        if (Input.GetKey(KeyCode.P))
        {
            camera.fieldOfView += 0.5f;
        }
        if (Input.GetKey(KeyCode.H))
        {
            camera.fieldOfView -= 0.5f;
        }
    }
}
