using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class spawner : MonoBehaviour
{
    private static int score=-6 ;
    public TextMeshProUGUI scorezone, end ;


    private void Start()
    {
        score = -6;
    }


    void OnCollisionExit2D(Collision2D smash) 
    { 
    if (smash.gameObject.tag == "Player") 
        {
            lives.live--;
        }
    
    }
    void OnCollisionEnter2D(Collision2D hit)
        

    {
        if (hit.gameObject.tag == "border")
        {
            float xPos = Random.Range(-30f, 37f);
            float yPos = Random.Range(33f, 50f);
            transform.position = new Vector2(xPos, yPos);
            score += 1;

        }

        
    }

    
    void Update()
    {
        scorezone.text = score.ToString();
        end.text = "MAHALLELÝLER SÝZÝ KOVDU \n SKOR:" + score.ToString();
    }
}
