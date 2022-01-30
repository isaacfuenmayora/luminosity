using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{
    private byte[] rgbIn;
    private ContactPoint2D[] contacts;
    // Start is called before the first frame update
    void Start()
    {
        rgbIn = new byte[6];
        contacts = new ContactPoint2D[6];
    }

    private void OnCollisionEnter2D(Collision2D collision){
        collision.GetContacts(contacts);
        for(int i=0; i<collision.contactCount; ++i){
            //Debug.Log(contacts[i].collider.tag);
            Debug.Log(contacts[i].otherCollider.tag);
            Debug.Log("...");
            if(contacts[i].otherCollider.tag){
                
            }
        }
    }
    // private void OnTriggerEnter2D(Collider2D other){
    //     Debug.Log(other.tag);
    //     // for(int i=0; i<other.contacts.Length; ++i)
    //     //     Debug.Log(other.contacts[i]);
    // }
    private void Update()
    {
        
    }
}
