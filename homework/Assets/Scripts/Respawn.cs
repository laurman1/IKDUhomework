using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnValue;
  
    void Update()
    {
        if (Enemy.transform.position.y < -spawnValue)
        if (player.transform.position.y < -spawnValue)
        {
            RespawnPoint();
        }
    }
    

    void RespawnPoint()
    {
        transform.position = spawnPoint.position;
    }

    
        
    
}
