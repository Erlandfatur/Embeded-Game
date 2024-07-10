using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarPlayer : MonoBehaviour
{
    public int stars = 0;
    public TMP_Text starText;
    public TMP_Text timeText;
    public GameController gamemaster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        starText.SetText("Stars: " + stars);
        if (stars < 3 && gamemaster.gameStarted == true)
            {
        timeText.SetText("Time: " + Mathf.Round(Time.time - gamemaster.startTime));
            }
            
        
    }
}
