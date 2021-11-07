using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    //public GameObject[] SkillPrefabs;
    //public int ability;

    public Image Fire;
    public Image Water;
    public Image Thunder;
    void Start()
    {
        Fire.enabled = false;
        Water.enabled = false;
        Thunder.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Fire.enabled = true;
            Water.enabled = false;
            Thunder.enabled = false;
        }
        if (Input.GetKeyDown("2"))
        {
            Fire.enabled = false;
            Water.enabled = true;
            Thunder.enabled = false;
        }
        if (Input.GetKeyDown("3"))
        {
            Fire.enabled = false;
            Water.enabled = false;
            Thunder.enabled = true;
        }
    }
}
