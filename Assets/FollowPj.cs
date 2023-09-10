using UnityEngine;
public class FollowPj : MonoBehaviour
{
    [SerializeField] private Transform Pj;
    void Start()
    {
        Pj = GameObject.FindObjectOfType<MoveSphere>().GetComponent<Transform>();
    }
    private void Update()
    {
        this.transform.LookAt(Pj);
    }
}
