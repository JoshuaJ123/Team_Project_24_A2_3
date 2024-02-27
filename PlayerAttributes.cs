using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{

    [SerializeField] private int health = 100;

    private int MaxHealth = 100;

    public void Awake()
    {
        health = MaxHealth;
    }
    void Update()
    {

    }

    public void SetHealth(int maxHealth, int health) 
    { 
        this.MaxHealth = maxHealth;
        this.health = health;
    }

    public void damage(int damageamount)
    {
        health -= damageamount;

        if (health <= 0) 
        {
            dead();
        }
    }

    private void dead()
    {
        Destroy(gameObject);
        Debug.Log("dead");
    }


}