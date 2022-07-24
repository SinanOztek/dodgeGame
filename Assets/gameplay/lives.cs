using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class lives : MonoBehaviour
{
    public static int live = 3;
    public TextMeshProUGUI health;
    public GameObject endZone;
    

    // Update is called once per frame
    void Update()
    {
        health.text = "lives :"+live.ToString();
        if( live == 0) 
        {
            Time.timeScale = 0;
            endZone.SetActive(true);
        }
    }
}
