using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CustomizedSceneController : MonoBehaviour
{
    public GameObject MainCam;
    public GameObject LevelPanel;
    public GameObject GamePanel;
    public GameObject StartingPanel;
    public GameObject JigsawElements;

    public Text[] LevelHighScoresTexts;
    public Text[] ThreelevelTexts; //(0,2,4)

    public static CustomizedSceneController instance;

    public static int activeLevel;


    public Text leveltext;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GoToGame(int id)
    {
        activeLevel = id;
        JigsawElements.gameObject.SetActive(true);
        GamePanel.gameObject.SetActive(true);
        LevelPanel.gameObject.SetActive(false);
        leveltext.text = "Level: " + activeLevel;
        MainCam.GetComponent<Demo>().SizeMode = id - 1;
        MainCam.GetComponent<Demo>().OnClickPlay();
    }



    public void GoToLevelSelection()
    {
        BGActivator.startExited = true;
        LevelPanel.gameObject.SetActive(true);
        StartingPanel.gameObject.SetActive(false);
    }


    public void OnClickRestartLevel()
    {
        MainCam.GetComponent<Demo>().RestartThisLevel();
    }

    public void OnClickBackToHome()
    {
        BGActivator.startExited = false;
        SceneManager.LoadScene("newPuzzleScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<LevelHighScoresTexts.Length; i++)
        {
            LevelHighScoresTexts[i].text = "Best: " + DataController.Instance.GetHighScores()[i] + "s";
            if(i == 0)
            {
                ThreelevelTexts[0].text = "Best: " + DataController.Instance.GetHighScores()[i] + "s";
            }

            else if(i == 2)
            {
                ThreelevelTexts[1].text = "Best: " + DataController.Instance.GetHighScores()[i] + "s";
            }
            else if(i == 4)
            {
                ThreelevelTexts[2].text = "Best: " + DataController.Instance.GetHighScores()[i] + "s";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
