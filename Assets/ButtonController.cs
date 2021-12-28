using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Sprite _on;
    public Sprite _off;
    private bool flg = true;


    void Start()
    {
        
    }

    
    void Update()
    {
        //左回転ボタンをタップすると画像が変わる処理
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //指定した画像へ切り替える
            gameObject.GetComponent<Animator>().Play("L1"); //「GetKeyDownの3種の違い」と「アニメーションの繰り返し設定」
        }

        //右回転ボタンをタップすると画像が変わる処理
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
        }
        
    }
}
