using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public Sprite trueGoal;
    public Sprite falseGoal;
    

    public void goalT()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = trueGoal;
    }
    public void goalF()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = falseGoal;
    }
}
