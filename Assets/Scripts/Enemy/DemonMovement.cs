using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonMovement : MonoBehaviour
{
    Transform player;
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindFirstObjectByType<PlayerMovement>().transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime); //moves the enemy towards the player (always).        
    }
}
