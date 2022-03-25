using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMashControllerr : MonoBehaviour
{
    public Camera cam;
    public GameObject prefab;
    private NavMeshAgent Agent;
    private Animator animator;
    Vector3 point;
    RaycastHit hitx;
    //float distance;

    // Start is called before the first frame update
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Debug.DrawRay(transform.position, Vector3.forward, Color.green);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                Agent.SetDestination(hit.point);
                animator.SetBool("walking",true);
                point = hit.point ;
                Instantiate(prefab,hit.point + Vector3.forward, transform.rotation);



            }

        }

        if(point.z == transform.position.z)
        {
            animator.SetBool("walking", false);
        
        }
    }
}
