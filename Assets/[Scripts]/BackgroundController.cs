using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 BackgroundController Script
 Yeongjin Lim
 101256371
 Last modified in: 2021-10-19
 Script for background scrolling
 changed tom's code to landscape orientation.
 */

//BG controller class
public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update for moving background and checking bounds
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //resets BG to original location
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    //move BG 
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    // if the background is lower than the side of the screen then reset
    private void _CheckBounds()
    {
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
