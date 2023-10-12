using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class FollowPj : MonoBehaviour
{
    [SerializeField] private List<MoveSphere>ListPj;
    [SerializeField] private Transform PJ;
    private Camera camera;
    void Start()
    {
        ListPj = new List<MoveSphere>(FindObjectsOfType<MoveSphere>());
        PJ = ListPj.Find(x => x.gameObject.name== "Character").GetComponent<Transform>();
        camera = this.GetComponent<Camera>();
    }
    private void Update()
    {
        //this.transform.LookAt(Pj);
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
