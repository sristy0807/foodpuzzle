using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{

    public Texture[] puzzles;
    public DemoJigsawPuzzle djp;
    private void OnEnable()
    {
        int id = Random.Range(0, puzzles.Length);
        djp.image = puzzles[id];
   
      
    }
}
