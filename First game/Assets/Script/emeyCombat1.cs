using UnityEngine;
using UnityEngine.Rendering;

public class emeyCombat : MonoBehaviour
{
    private bool isAlive = true;
    public float health = 3;

    public float attackRange = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(health <= 0)
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
