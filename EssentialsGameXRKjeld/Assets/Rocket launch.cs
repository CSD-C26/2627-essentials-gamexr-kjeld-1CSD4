using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Rocketlaunch : MonoBehaviour
{
    private int score = 1;
    private float counter = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counter ++;
        counter = counter + Time.deltaTime;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
           score++;
        }

        if (counter >= 600)
        {
           score++;
           counter = 0; 
        }
        
        transform.position = transform.position + Vector3.up * score / 10000;
        Debug.Log(score);
    }
}
