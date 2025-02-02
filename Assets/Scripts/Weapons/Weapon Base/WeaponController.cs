using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    [Header("Weapon Stats")] //Base for all weapon ctrls
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    float currentCooldown;
    public int pierce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    protected PlayerMovement pm;
    protected virtual void Start()
    {
        pm = FindFirstObjectByType<PlayerMovement>();
        currentCooldown = cooldownDuration;
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0f)
        {
            Attack();
        }
        
    }
    protected virtual void Attack()
    {
        currentCooldown = cooldownDuration;
    }
}
