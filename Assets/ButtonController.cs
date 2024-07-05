using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    //↓ネットで見つけた「Buttonを押してImageを変更する」のやり方。一応メモで残してるだけ。（適当にやって出来な方のでボツにした）
    /*public Sprite _on;
    public Sprite _off;
    private bool flg = true;

    public void changeImage()
    {
        var img = GetComponent<Image>();
        img.sprite = (flg) ? _on : _off;
        flg = !flg;
    }*/


    void Start()
    {
        
    }

    
    void Update()
    {
        //左回転ボタンをタップすると画像が変わる処理
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //指定した画像へ切り替える  （アニメだと挙動がうまくいかない）
            gameObject.GetComponent<Animator>().Play("L1");      //「GetKeyDownの3種の違い」と「アニメーションの繰り返し設定」
        }

        //右回転ボタンをタップすると画像が変わる処理
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
        }
        
    }
}
