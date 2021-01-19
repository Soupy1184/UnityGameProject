using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
	public GameObject spawnPoint;
	public GameObject enemy;
    // Start is called before the first frame update
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            Destroy(enemy);
        }
    }
}
