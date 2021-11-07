using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        Player = GameObject.Find("Player");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fire"))
        {
            if(Player.GetComponent<PlayeController>().fire == true)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.CompareTag("Water"))
        {
            if (Player.GetComponent<PlayeController>().water == true)
            {
                Destroy(collision.gameObject);
            }
            
        }
        if (collision.gameObject.CompareTag("Thunder"))
        {
            if (Player.GetComponent<PlayeController>().thunder == true)
            {
                Destroy(collision.gameObject);
            }
        }
    }
        void Update()
        {

        }
    
}
