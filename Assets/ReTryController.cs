using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadSceneを使う為に必要

public class ReTryController : MonoBehaviour
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
        //これ毎秒の必要性ある？
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<AudioSource>().Play();

            gameObject.GetComponent<Animator>().Play("RETRY");

            Invoke("SceneChange", 0.88f);
        }
    }
}
