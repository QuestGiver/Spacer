using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int bulletHitCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            bulletHitCount++;
            if (bulletHitCount > 3)
            {
                Destroy(gameObject);
            }
        }
    }

}
