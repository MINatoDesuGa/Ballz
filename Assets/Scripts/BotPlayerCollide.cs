using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPlayerCollide : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GameOverScreen.Setup(GemsScore.gems, GemsScore.score);
        }
    }
}
