using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMeshController : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position - offset, target.transform.position, 1f);
    }
}
