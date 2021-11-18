using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayeController : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerSpeed = 2.0f;
    public float jumpPower;

    public bool isGround;

    /*
    private bool SelectSkill = false;
    public Image SkillFire;
    public Image SkillWater;
    public Image SkillThunder;
    */

    public Text clearText;

    public bool fire = false;
    public bool water = false;
    public bool thunder = false;
    public bool skill = true;

    public bool menu;
    public static bool terms;

    public GameObject buttonContinue;
    public GameObject buttonReset;
    public GameObject buttonTitle;

    public GameObject goal;
    void Start()
    {
        /*
        SkillFire.enabled = false;
        SkillWater.enabled = false;
        SkillThunder.enabled = false;
        */
        goal = GameObject.Find("Image(Goal)");
        menu = false;
        if (SceneManager.GetActiveScene().buildIndex == 1 | SceneManager.GetActiveScene().buildIndex == 4)
        {
            terms = true;
            //goal.GetComponent<GoalScript>().goalT();
        }
        else
        {
            terms = false;
            //goal.GetComponent<GoalScript>().goalF();
        }
            
        rb = GetComponent<Rigidbody2D>();
        clearText.enabled = false;

        buttonContinue.SetActive(false);
        buttonReset.SetActive(false);
        buttonTitle.SetActive(false);

        
    }

    
    void Update()
    {
        /*
        if (Input.GetKeyDown("q"))//'q'を押したら
        {
            
            SkillFire.enabled = true;
            SkillWater.enabled = true;      //画像を表示
            SkillThunder.enabled = true;
            
        }
        if (Input.GetKeyUp("q"))//'q'を押したら
        {
            SkillFire.enabled = false;
            SkillWater.enabled = false;     //画像を非表示
            SkillThunder.enabled = false;
        }
        */

        if (Input.GetKeyDown("1"))
        {
            fire = true;
            skill = false;
        }
        if (Input.GetKeyUp("1"))
        {
            fire = false;
        }
        if (Input.GetKeyDown("2"))
        {
            water = true;
            skill = false;
        }
        if (Input.GetKeyUp("2"))
        {
            water = false;
        }
        if (Input.GetKeyDown("3"))
        {
            thunder = true;
            skill = false;
        }
        if (Input.GetKeyUp("3"))
        {
            thunder = false;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            if (menu == false)
            {
                Time.timeScale = 0f;
                menu = true;
                buttonContinue.SetActive(true);
                buttonReset.SetActive(true);
                buttonTitle.SetActive(true);
            }
        }

        if(terms == true)
        {
            goal.GetComponent<GoalScript>().goalT();
        }
        if(terms == false)
        {
            goal.GetComponent<GoalScript>().goalF();
        }
    }
    public void Continue()
    {
            if(menu == true)
            {
                Time.timeScale = 1f;
                menu = false;
            buttonContinue.SetActive(false);
            buttonReset.SetActive(false);
            buttonTitle.SetActive(false);
        }
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") | collision.gameObject.CompareTag("Fire_Destroy"))
        {
            isGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            if(terms == true)
            {
                if (SceneManager.GetActiveScene().buildIndex == 1)
                {
                    SceneManager.LoadScene("Stage2Scene");
                }
                if(SceneManager.GetActiveScene().buildIndex == 2)
                {
                    SceneManager.LoadScene("Stage3Scene");
                }
                if (SceneManager.GetActiveScene().buildIndex == 4)
                {
                    SceneManager.LoadScene("Stage4Scene");
                }             
                if(SceneManager.GetActiveScene().buildIndex == 5)
                {
                    clearText.enabled = true;
                }
            }
            
        }
    }

    private void FixedUpdate()
    {
        var velox = playerSpeed * Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(velox, rb.velocity.y); //左右の動き

        if (Input.GetKey(KeyCode.Space))
        {
            if(isGround == true)
            {
                rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
                //rb.AddForce(transform.up * jumpPower);
            isGround = false;
            }

        }


        var x = Input.GetAxisRaw("Horizontal");
        // デフォルトが右向きの画像の場合
        // スケール値取り出し
        Vector3 scale = transform.localScale;
        if (x > 0)
        {
            // 右方向に移動中
            scale.x = 1; // そのまま（右向き）
        }
        if(x < 0)
        {
            // 左方向に移動中
            scale.x = -1; // 反転する（左向き）
        }
        // 代入し直す
        transform.localScale = scale;

    }

}