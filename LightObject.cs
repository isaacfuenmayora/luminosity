using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObject : MonoBehaviour
{
    private Vector2 direction=GameManager.SE; //E,W,NE,NW,SE,SW
    private byte RGB;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction* GameManager.speed * Time.deltaTime);
    }
}