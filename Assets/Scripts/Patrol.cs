using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool movingR = true;

    public Transform borderDetect;

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(borderDetect.position, Vector2.up, distance);

        if(!groundInfo.collider)
        {
            if(movingR)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingR = false;
            } else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingR = true;
            }
        }

    }
}
