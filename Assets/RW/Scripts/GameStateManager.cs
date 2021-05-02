using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance; // 1

    public int sheepSaved=0; // 2
    public int sheepDropped=0; // 3
    public SheepSpawner sheepSpawner; // 5
    public int Score=0;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }
        
    }
    public void SavedSheep()
    {
        sheepSaved++;
        Score++;
        UImanager.Instance.UpdateSheepSaved();
    }
    
    public void DroppedSheep()
    {
        sheepDropped++; // 1
        Score--;
        UImanager.Instance.UpdateSheepDropped();
    }

}
