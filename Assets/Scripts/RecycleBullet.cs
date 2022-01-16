using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBullet : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -30)
        {
            Destroy(gameObject);
        }
    }
}
