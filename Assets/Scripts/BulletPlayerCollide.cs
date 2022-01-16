using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayerCollide : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            GameOverScreen.Setup(GemsScore.gems, GemsScore.score);
        }
    }
}
