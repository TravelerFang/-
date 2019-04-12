using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///<summary>
///按下Q W E 播放动画 
///动画名字必须为01 02 03
///最多添加三个动画
///</summary>
[RequireComponent(typeof(Animation))]
public class AnimationCtrl : MonoBehaviour 
{
    private Animation ani;
    private void Start()
    {
        ani = GetComponent<Animation>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ani.Play("01");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            ani.Play("02");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            ani.Play("03");
        }
    }
}
