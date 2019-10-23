using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIscript : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public GameObject gameOverpanel;
    public GameObject startButton;
    //public GameObject pause;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Scorepoints());
        Time.timeScale = 0;
    }


    public void Onpausebuttonpressed()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //public IEnumerator Scorepoints()
    //{
    //    yield return new WaitForSeconds(1);
    //    score += 1;
    //    scoreText.text = " Score: " + score;
    //    StartCoroutine(Scorepoints());
    //}

    public void Increascore()
    {
        score++;
        scoreText.text = "score:" + score; 
    }
    public void MakeGameover()
    {
        gameOverpanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Onstartbuttonpressed()
    {
        startButton.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnRestartbuttonpressed()
    {
        string currentscene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentscene);
    }
}
