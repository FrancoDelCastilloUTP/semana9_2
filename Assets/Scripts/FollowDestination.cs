using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestination : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent theAgent = null;
    public Transform destination = null;
    void Start()
    {
        theAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        theAgent.SetDestination(destination.position);
    }
}
