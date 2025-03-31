using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : States
{
    // Bullet Variables
    public GameObject enemyBullet;
    public GameObject spawnPoint;
    private float bulletTime;

    [SerializeField] private float Timer = 5;

    public override States RunCurrentState()
		{
			Debug.Log("Attacking the opponent YAAARGH!");
            ShootAtPlayer();
			return this;
		}

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = Timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * 5000);
        Destroy(bulletObj, 5f);
    }
}
