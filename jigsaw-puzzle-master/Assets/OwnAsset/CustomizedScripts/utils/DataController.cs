using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DataController : Singleton<DataController>
{
    PlayerProgress playerProgress;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        LoadPlayerProgress();
        //Invoke("LoadNewScene", 2.0f);
        LoadNewScene();
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("newPuzzleScene");
    }

    public void SubmitNewPlayerScore(float newScore, int level)
    {
        if (playerProgress.highScores[level - 1] != 0)
        {
            if (newScore < playerProgress.highScores[level - 1])
            {
                playerProgress.highScores[level - 1] = newScore;
                
            }
        }
        else
        {
            playerProgress.highScores[level - 1] = newScore;
        }

        SavePlayerProgress(level);
    }

    public float[] GetHighScores()
    {
        return playerProgress.highScores;
    }

    void LoadPlayerProgress()
    {
        playerProgress = new PlayerProgress();
        if (PlayerPrefs.HasKey("H1"))
        {
            playerProgress.highScores[0] = PlayerPrefs.GetFloat("H1");
        }

        if (PlayerPrefs.HasKey("H2"))
        {
            playerProgress.highScores[1] = PlayerPrefs.GetFloat("H2");
        }

        if (PlayerPrefs.HasKey("H3"))
        {
            playerProgress.highScores[2] = PlayerPrefs.GetFloat("H3");
        }

        if (PlayerPrefs.HasKey("H4"))
        {
            playerProgress.highScores[3] = PlayerPrefs.GetFloat("H4");
        }

        if (PlayerPrefs.HasKey("H5"))
        {
            playerProgress.highScores[4] = PlayerPrefs.GetFloat("H5");
        }

        if (PlayerPrefs.HasKey("H6"))
        {
            playerProgress.highScores[5] = PlayerPrefs.GetFloat("H6");
        }

        if (PlayerPrefs.HasKey("H7"))
        {
            playerProgress.highScores[6] = PlayerPrefs.GetFloat("H7");
        }

        if (PlayerPrefs.HasKey("H8"))
        {
            playerProgress.highScores[7] = PlayerPrefs.GetFloat("H8");
        }

        if (PlayerPrefs.HasKey("H9"))
        {
            playerProgress.highScores[8] = PlayerPrefs.GetFloat("H9");
        }

        if (PlayerPrefs.HasKey("H10"))
        {
            playerProgress.highScores[9] = PlayerPrefs.GetFloat("H10");
        }
    }


    private void SavePlayerProgress(int lvl)
    {
        // Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
        string key = "H" + lvl;
        PlayerPrefs.SetFloat(key, playerProgress.highScores[lvl-1]);
    }

}
