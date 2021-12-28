using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadSceneを使う為に必要

public class BallController : MonoBehaviour
{
    //ボール衝突時のSEの入れ物変数
    public AudioClip xSE;
    public AudioClip otherSE;
    public AudioClip gameOverSE;
    AudioSource myaudioSource;

    //ゲームオーバー画面へ移行するエリア
    private float okAreaUpY = 8.5f;
    private float okAreaUnderY = -5.735f;
    private float okAreaLeftX = -6.31f;
    private float okAreaRightX = 6.31f;

    //ゲーム開始と共にボールが飛ぶ方向
    private Rigidbody2D myRigidBody;
    public float speedX = -10f;
    public float speedY = -10f;

    
    void Start()
    {
        //ゲーム開始と共にボールが飛ぶ
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 force = new Vector2(speedX, speedY);

        myRigidBody.AddForce(force);


        //AudioSourceを代入してゲット
        this.myaudioSource = GetComponent<AudioSource>();
    }


    
    //ボール衝突事の音声ファイルの実態をインスペクタで入れるCDコンポを用意 ＋ Xの光るアニメーション
    void OnCollisionEnter2D(Collision2D other)   //なぜ「Update」ではエラーになるんだろう？
    {
        if (other.gameObject.tag == "XTag")
        {
            this.myaudioSource.PlayOneShot(this.xSE);

            other.gameObject.GetComponent<Animator>().Play("X");  //「other.gameObject.」でどの「Animator」かを特定してる
        }
        else
        {
            this.myaudioSource.PlayOneShot(this.otherSE);
        }
    }


    //ゲームオーバーの音声ファイルの実態をインスペクタで入れるCDコンポを用意
    void OnTriggerEnter2D(Collider2D other)  //「Trigger」は「Collision」じゃなく「Collider」じゃなきゃダメ
    {
        //Debug.Log("na");
        if (other.gameObject.tag == "GameOverSETag")
        {
            //Debug.Log("OK");
            this.myaudioSource.PlayOneShot(this.gameOverSE);
        }
    }


    void Update()
    {
        //ゲームオーバー画面へ移行
        if (this.transform.position.y > this.okAreaUpY)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        if (this.transform.position.y < this.okAreaUnderY)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        if (this.transform.position.x < this.okAreaLeftX)
        {
            SceneManager.LoadScene("GameOverScene");
        }

        if (this.transform.position.x > this.okAreaRightX)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
