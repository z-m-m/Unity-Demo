using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeMove : MonoBehaviour {   
    private NavMeshAgent meshAgent;
	void Start () {
        meshAgent = transform.GetComponent<NavMeshAgent>();      
	}

    private void Update()
    {

        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            {
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1 << LayerMask.NameToLayer("Floor"))) {
                    meshAgent.SetDestination(hit.point);
                }
            }
        }
    }
}
