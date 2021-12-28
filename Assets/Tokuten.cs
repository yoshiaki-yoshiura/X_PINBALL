using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;　//これを加える事でUnityのUI機能を使う事ができる。

public class Tokuten : MonoBehaviour
{
    //scoreを加算する変数を宣言し0を代入　　　　　　　　（※他のシーンでも使えるようpublicでstaticな変数で宣言）
    public static int tokuten = 0;                //変更前（private int tokuten = 0;）
    
    //UI「TokutenText」を代入する為の変数を宣言（Startで代入）
    private GameObject tokutenText;


    //scoreを加算するtokuten変数に合計していく関数（引数でscore変数を受け取り+=で加算）
    void Score(int score)
    {
        //得点を「tokuten」に合計していく　　　　　　　（※tokutenがpublicでstaticな変数になったので、thisを削除）
        tokuten += score;                         //変更前（this.tokuten += score;）

        //tokutenの合計値を表示
        this.tokutenText.GetComponent<Text>().text = "" + tokuten;
    }


    //↓衝突時に実行され、合計関数に引数を渡し実行するトリガー（自分のColliderが他のオブジェクトのColliderと接触した時に呼ばれる）
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "XTag")　　　　　　　　　// == → 左辺と右辺が等しい場合にtrue
        {
            Score(10);　　　//10点加算（10点を「score」に代入）
        }
    }


    //合計値「tokuten」を他のシーンでも共有できるように
    public static int getTokuten()
    {
        return tokuten;
    }


    void Start()
    {
        //UI「TokutenText」を代入し取得（取得はスタートでやっとく）
        this.tokutenText = GameObject.Find("TokutenText");

        tokuten = 0;
    }

    void Update()
    {
        
    }


    

}