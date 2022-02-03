using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControl : MonoBehaviour
{
    [SerializeField]

    public Transform home;
    NavMeshAgent agent;

    void Start () {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }
    void Update () {
        agent.SetDestination(home.position);

    }
}
