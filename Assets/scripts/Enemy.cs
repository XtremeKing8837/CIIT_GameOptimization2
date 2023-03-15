using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public GameObject BloodFX;

    public NavMeshAgent agent;
    public Transform PlayerPosition;

    private void Start()
    {
        agent.SetDestination(PlayerPosition.position);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Instantiate(BloodFX,transform.position,transform.rotation);
        }
    }

}
