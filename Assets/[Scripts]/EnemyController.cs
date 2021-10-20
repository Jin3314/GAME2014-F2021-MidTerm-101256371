using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 EnemyController Script
 Yeongjin Lim
 101256371
 Last modified in: 2021-10-19
 Script for EnemyControl
 changed tom's code to landscape orientation.
 */

//class for enemycontrol
public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Updates enemy's move and bound
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //this make enemies to move up and down
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    //checks enemy's bound
    private void _CheckBounds()
    {
        // check up boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check down boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
