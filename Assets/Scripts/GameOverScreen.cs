using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text totalText;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void Setup(int gems, int score)
    {
        gameObject.SetActive(true);
        totalText.text = gems.ToString() + " X Gems\n" + "Score : " + score.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
