using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static byte R=1, G=2, B=4;
    public static Vector2 NW = new Vector2(-0.5f, 0.86602540378f),
                           W = new Vector2(-1f, 0f),
                          SW = new Vector2(-0.5f,-0.86602540378f),
                          SE = new Vector2( 0.5f,-0.86602540378f),
                           E = new Vector2( 1f, 0f),
                          NE = new Vector2( 0.5f, 0.86602540378f);
    public static float speed = .3f;
}
