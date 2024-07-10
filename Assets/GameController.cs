using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameController : MonoBehaviour
{
    public GameObject canvas;
    public bool gameStarted = false;
    public float startTime = 0.0f;
    GameObject[] stars;
    // Start is called before the first frame update

    public void PlayerReady()
    {
    gameStarted = true;
    startTime = Time.time; // Time when the button is pressed
    canvas.SetActive(false);
    foreach (var star in stars)
    {
        star.SetActive(true);
    }
    }
    void Start()
    {
        canvas.SetActive(false);
        stars = GameObject.FindGameObjectsWithTag("Star");
        foreach (var star in stars)
        {
            star.SetActive(false);
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
    if (other.CompareTag("Player"))
    {
        canvas.SetActive(true);
    }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")&& gameStarted == false)
        {
            canvas.SetActive(false);
        }
    }
}
