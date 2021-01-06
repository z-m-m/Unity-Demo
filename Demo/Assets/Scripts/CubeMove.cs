using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class CubeMove : MonoBehaviour {   
    private NavMeshAgent meshAgent;
    public ThirdPersonCharacter character;
	void Start () {
        meshAgent = transform.GetComponent<NavMeshAgent>();
        meshAgent.updateRotation = false;
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
        if (meshAgent.remainingDistance > meshAgent.stoppingDistance)
        {
            character.Move(meshAgent.desiredVelocity, false, false);
        }
        else {
            character.Move(Vector3.zero,false,false);
        }
        
    }
}
