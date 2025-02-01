using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiBehaviour : ProjectileWeaponBehaviour
{
    SaiController sc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        sc = FindFirstObjectByType<SaiController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * sc.speed * Time.deltaTime;   
    }
}
