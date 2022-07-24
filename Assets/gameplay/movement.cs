using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float mSpeed;
    

    // Update is called once per frame
    void Update()
    {
        float speed = mSpeed * Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime ,0, 0);
    }
}
