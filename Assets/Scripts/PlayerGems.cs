using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGems : MonoBehaviour
{
    GameObject gem;

    private void Start()
    {
        gem = gameObject.transform.gameObject;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GemsScore.score += 10; GemsScore.gems++;
            Destroy(gem);        
        }
    }
}
