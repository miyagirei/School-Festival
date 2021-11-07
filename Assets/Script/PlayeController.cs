using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayeController : MonoBehaviour
{
    Rigidbody2D rb;
    public float PlayerSpeed = 2.0f;

    //private bool SelectSkill = false;
    //public Image SkillFire;
    //public Image SkillWater;
    //public Image SkillThunder;

    public bool fire = false;
    public bool water = false;
    public bool thunder = false;
    void Start()
    {
        //SkillFire.enabled = false;
        //SkillWater.enabled = false;
        //SkillThunder.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("q"))//'q'を押したら
        {
            //SkillFire.enabled = true;
            //SkillWater.enabled = true;      //画像を表示
            //SkillThunder.enabled = true;
        }
        if (Input.GetKeyUp("q"))//'q'を押したら
        {
            //SkillFire.enabled = false;
            //SkillWater.enabled = false;     //画像を非表示
            //SkillThunder.enabled = false;
        }

        if (Input.GetKeyDown("1"))
        {
            fire = true;
        }
        if (Input.GetKeyUp("1"))
        {
            fire = false;
        }
        if (Input.GetKeyDown("2"))
        {
            water = true;
        }
        if (Input.GetKeyUp("2"))
        {
            water = false;
        }
        if (Input.GetKeyDown("3"))
        {
            thunder = true;
        }
        if (Input.GetKeyUp("3"))
        {
            thunder = false;
        }
    }

    //public void OnDetectObject(Collider collider
    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Fire") && Input.GetKeyDown("1"))
        {
           
        }
        if (gameObject.CompareTag("Water") && Input.GetKeyDown("2"))
        {

        }
        if (gameObject.CompareTag("Thunder") && Input.GetKeyDown("3"))
        {

        }
    }
    */
  

    private void FixedUpdate()
    {
        var velox = PlayerSpeed * Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(velox, 0f); //左右の動き


    }
}