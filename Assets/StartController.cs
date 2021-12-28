using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadSceneを使う為に必要

public class StartController : MonoBehaviour
{
    void SceneChange()
    {
        SceneManager.LoadScene("X_PINBALL");
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        //これ毎秒の必要性ある？（操作）
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<AudioSource>().Play();

            gameObject.GetComponent<Animator>().Play("START");

            Invoke("SceneChange", 0.88f);
        }
    }
}
