using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Base script of all projectile behaviours [To be placed on a prefab of a weapon that is a projectile]
/// </summary>
public class ProjectileWeaponBehaviour : MonoBehaviour
{
    protected Vector3 direction;

    public float destroyAfterSeconds;

    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }

    public void DirectionChecker(Vector3 dir)
    {
        direction = dir;

        float dirx = direction.x;
        float diry = direction.y;

        Vector3 scale = transform.localScale;
        Vector3 rotation = transform.rotation.eulerAngles;

        if (dirx < 0 && diry == 0) //left
        {
            scale.x = scale.x * -1;
            scale.y = scale.y * -1;
        }
        else if (dirx == 0 && diry < 0) //down
        {
            rotation.z = -90f;
        }
        else if (dirx == 0 && diry > 0) //up
        {
            rotation.z = 90f;
        }
        else if (dirx > 0 && diry > 0) //right up
        {
            rotation.z = 45f;
        }
        else if (dirx > 0 && diry < 0) //right down
        {
            rotation.z = -45f;
        }
        else if (dirx < 0 && diry > 0) //left up
        {
            rotation.z = 135f;
        }
        else if (dirx < 0 && diry < 0) //left down
        {
            rotation.z = -135f;
        }

        transform.localScale = scale;
        transform.rotation = Quaternion.Euler(rotation);
    }
}