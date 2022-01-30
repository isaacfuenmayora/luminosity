using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightObject : MonoBehaviour
{
    [SerializeField]
    private Vector2 direction; //E,W,NE,NW,SE,SW
    [SerializeField]
    public byte RGB;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction* GameManager.speed * Time.deltaTime);
    }
}