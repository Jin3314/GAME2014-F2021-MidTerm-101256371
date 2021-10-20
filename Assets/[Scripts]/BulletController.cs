using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 BulletController Script
 Yeongjin Lim
 101256371
 Last modified in: 2021-10-19
 Script for Bulletcontrol
 changed tom's code to landscape orientation.
 */

//class for BulletControl
public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Updates bullet's move and checks bullet's bound
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // makes bullet move to rightside
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    //checks bounds
    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    //checks trigger and collider
    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    //applies damage to enemy
    public int ApplyDamage()
    {
        return damage;
    }
}
