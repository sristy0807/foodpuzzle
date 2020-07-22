using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizedLevelButton : MonoBehaviour
{
    [SerializeField]
    int id;

    
    // Start is called before the first frame update
    void OnEnable()
    {
        //GetComponentInChildren<Text>().text = "Level " + id;


    }
    
    public void OnClickThisLevel()
    {
        CustomizedSceneController.instance.GoToGame(id);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
