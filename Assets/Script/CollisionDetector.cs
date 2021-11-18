using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject Player;
    public GameObject candle;
    public GameObject desObj;
    void Start()
    {
        Player = GameObject.Find("Player");
        candle = GameObject.Find("Image(candle)");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Player.GetComponent<PlayeController>().fire == true)
        {
            if(collision.gameObject.CompareTag("Fire_Destroy"))
            {
                //Destroy(collision.gameObject);
                desObj = (collision.gameObject);
                desObj.SetActive(false);
            }
            if (collision.gameObject.CompareTag("Fire_Candle"))
            {
                candle.GetComponent<Candle>().fireCandle();
            }
        }

        if (Player.GetComponent<PlayeController>().water == true)
        {
            if (collision.gameObject.CompareTag("Water_Destroy"))
            {
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.CompareTag("Fire_Candle"))
            {
                candle.GetComponent<Candle>().disFireCandle();
            }
        }

        if (Player.GetComponent<PlayeController>().thunder == true)
        {
            if (collision.gameObject.CompareTag("Thunder_generate"))
            {
                desObj.SetActive(true);
            }
        }
    }
}
