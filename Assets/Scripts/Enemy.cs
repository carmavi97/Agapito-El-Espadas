using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHeath = 100;
    int currentHeath;
    // Start is called before the first frame update
    void Start()
    {
        currentHeath = maxHeath;
    }

    public void TakeDamage(int damage)
    {
        currentHeath -= damage;

        //Play Animation
        animator.SetTrigger("Hurt");
        if (currentHeath == 0)
        {
            Die();
        }
    }

    void Die()
    {
        //die animation and disable de enemy
        Debug.Log("Enemy died");

        animator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        
    }
}
