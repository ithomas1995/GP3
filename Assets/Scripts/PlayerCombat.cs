using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 20;
    public PlayerGrow script;
    public GameObject BigGuy;

    public int health;
    public int currentHealth;



    void Start()
    {
        script.isBig = false;
        currentHealth = health;
    }
    // Update is called once per frame
    void Update()
    {   
        if (Input.GetButtonDown("Fire1") && script.isBig == true)
        {
            AttackBig();
        }

        if (Input.GetButtonDown("Fire1") && script.isBig == false)
        {
            AttackSmall();
        }

        if(script.isBig == true)
        {
            attackDamage = 10000;
            currentHealth = 55000;
        }
        else
        {
        attackDamage = 20;
        currentHealth = 100;
        }
    }

    void AttackBig()
    {
        //play animation

        //detect enemies
       Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        // Damage
        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<BigEnemyRobot>().BigTakeDamage(attackDamage);
            Debug.Log("taking damage");
            
        }
    }

    void AttackSmall()
    {
        //play animation

        //detect enemies
       Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        // Damage
        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyRobot>().TakeDamage(attackDamage);
            Debug.Log("taking damage");
            
        }
    }

    public void PlayerDamage(int damage)
    {
        currentHealth -= damage;
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
