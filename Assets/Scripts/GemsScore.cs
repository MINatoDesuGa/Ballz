using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemsScore : MonoBehaviour
{
    public static int gems = 0, score = 0;
    public GameOverScreen GameOverScreen;
    Text gsText;
    void Start()
    {
        gsText = GetComponent<Text>();
        gems = 0;   score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gsText.text = "Gems: " + gems + "  Score: " + score;
        if(gems == 6)
        {
            GameOverScreen.Setup(gems, score);
        }
    }
}
