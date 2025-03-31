using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // NavMesh MOVESET Variables
    public NavMeshAgent enemy;
    public Transform Player;
    public float enemySpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       enemy.SetDestination(Player.position);
    }
}
