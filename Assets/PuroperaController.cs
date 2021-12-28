using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuroperaController : MonoBehaviour
{
    // 回転速度の変数を用意し、初期値を0で代入
    float rotSpeed = 0;


    void Start()
    {
        
    }

    
    void Update()
    {
        //タップすると回転速度が与えられる
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rotSpeed = 5f; //変数に2を代入し、左回転設定
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            this.rotSpeed = 0f; //
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rotSpeed = -5f; //変数に-2を代入し、右回転設定
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            this.rotSpeed = 0f; //
        }
    }

    void FixedUpdate()
    {
        //与えられた回転速度分プロペラを回転させる　　↓端末の性能差によって処理が変わるのを防ぐ（入力によって操作するものに付ける）
        transform.Rotate(0, 0, this.rotSpeed);
    }

}