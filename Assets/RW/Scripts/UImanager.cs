using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public static UImanager Instance; // 1
    public Text sheepSavedText; // 2
    public Text scoreText;
  

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateSheepSaved() // 1
    {
        sheepSavedText.text = GameStateManager.Instance.sheepSaved.ToString();
        scoreText.text=GameStateManager.Instance.Score.ToString();

    }
    public void UpdateSheepDropped() // 2
    {
        scoreText.text=GameStateManager.Instance.Score.ToString();
    }
    
}
