using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;
    public float LerpRate;
    public bool gameOver;
    void Start()
    {
        offset= ball.transform.position - transform.position;
        gameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            Follow();
        }
    }
    void Follow()
    {
        Vector3 pos =transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos= Vector3.Lerp(pos, targetPos,LerpRate * Time.deltaTime);
        transform.position=pos;
    }
}
