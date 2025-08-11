using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    public Transform enemy;
    public Transform player;
    private NavMeshAgent agent;

    public float speed = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        
        agent.SetDestination(player.position);
    }
}
