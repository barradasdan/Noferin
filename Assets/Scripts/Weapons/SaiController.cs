using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaiController : WeaponController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();   
    }

    // Update is called once per frame
    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedSai = Instantiate(prefab);
        spawnedSai.transform.position = transform.position;
        spawnedSai.GetComponent<SaiBehaviour>().DirectionChecker(pm.moveDir);   
    }
}
