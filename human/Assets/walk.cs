using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class walk : MonoBehaviour
    
{private NavMeshAgent myAgent;
 
    public Transform target;
    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        myAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0) )
        {
            myAnimator.Play("Арматура|АрматураAction_001");

        }
       
    }
}
