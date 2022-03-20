using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemyRobot : MonoBehaviour
{
    public int BigmaxHealth = 50000;
    public int BigcurrentHealth;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        BigcurrentHealth = BigmaxHealth;
    }

    public void BigTakeDamage(int damage)
    {
        
        BigcurrentHealth -= damage;
       

        if(BigcurrentHealth <= 0)
        {
            BigDie();
        }
        
    }

    
    void BigDie()
    {
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}
