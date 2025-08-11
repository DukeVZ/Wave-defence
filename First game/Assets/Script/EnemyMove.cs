using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    public Transform enemy;
    public Transform player;
    NavMeshAgent agent;

    public float speed = 1f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        Vector3 directionToPlayer = (player.position - transform.position).normalized;
    }
}
