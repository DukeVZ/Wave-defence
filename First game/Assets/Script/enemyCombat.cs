using UnityEngine;

public class enemyCombat : MonoBehaviour
{
    private bool isAlive = true;
    public float health = 3;

    public Transform player;

    public float attackRange = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if()

        if (health <= 0)
        {
            isAlive = false;
        }
        else isAlive = true;


        if (isAlive == false)
        {
            Destroy(gameObject);
        }
    }
}
