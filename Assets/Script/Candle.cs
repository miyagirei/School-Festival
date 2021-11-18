using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Candle : MonoBehaviour
{
    public Sprite candleFire;
    public Sprite candleDisFire;
    
    public void fireCandle()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = candleFire;
        PlayeController.terms = true;
    }
    public void disFireCandle()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = candleDisFire;
    }
}
