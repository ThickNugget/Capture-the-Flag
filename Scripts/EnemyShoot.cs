using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : Enemy
{
    public float shootDistance;
    public GameObject Bullet;
    public float rateOfFire;
        public float lastShotTime;
    // Start is called before the first frame update
    void Start()
    {
        SetupVariables();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position,
            Player.transform.position) >= shootDistance)
        {
            MoveTowardsPlayer();
        }
        else;
        {
            navAgent.destination = transform.position;
            if (lastShotTime + rateOfFire <Time.time)
            {
                ShootBullet();
                lastShotTime = Time.time;
            }
        }

    }

void ShootBullet()
    {
        GameObject bullet = Instantiate(Bullet, transform.position, transform.rotation);
        bullet.transform.LookAt(Player.transform, Vector3.up);
    }




}
