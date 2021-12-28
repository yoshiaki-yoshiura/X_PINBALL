using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;　//これを加える事でUnityのUI機能を使う事ができる。

public class GameOverDirector : MonoBehaviour
{
    //「Tokuten」スクリプトのスコア（合計値「tokuten」）を代入する変数を宣言
    public int nowScore;
    //「PlayerPrefs」を代入する変数を宣言
    public int highScore = 0;


    //UI「NowScoreText」と「HighScoreText」を代入する変数を宣言（Startで代入）
    private GameObject nowScoreText;
    private GameObject highScoreText;


    void Start()
    {
        //UI「NowScoreText」と「HighScoreText」を代入し取得（取得はスタートでやっとく）
        this.nowScoreText = GameObject.Find("NowScoreText");
        this.highScoreText = GameObject.Find("HighScoreText");


        //「Tokuten」スクリプトから取得したスコア（合計値「tokuten」）を代入
        nowScore = Tokuten.getTokuten();
        //nowScoreを表示
        this.nowScoreText.GetComponent<Text>().text = "" + nowScore;


        //"SCORE"をキーとしてハイスコアをロード（値がない場合は0になる）
        highScore = PlayerPrefs.GetInt("SCORE", 0);

        //highScoreを表示　　※これが↑と↓の間に記載されていることが大事（スクリプトは上から順に実行されるから）
        this.highScoreText.GetComponent<Text>().text = "HIGH SCORE   " + highScore;

        if (highScore < nowScore)  //スコアがハイスコアを超えたら実行
        {
            highScore = nowScore;  //ハイスコアをスコアで上書き

            PlayerPrefs.SetInt("SCORE", highScore);  //"SCORE"をキーとして上書きされたハイスコアを保存
            PlayerPrefs.Save();                      //ディスクへの書き込み
        }
    }


    void Update()
    {

    }
}
