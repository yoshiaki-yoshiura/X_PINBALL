using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //LoadSceneを使う為に必要

public class TopController : MonoBehaviour
{
    void SceneChange()
    {
        SceneManager.LoadScene("TopScene");
    }


    void Start()
    {
        
    }

    
    void Update()
    {
        //これ毎秒の必要性ある？
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<AudioSource>().Play();

            gameObject.GetComponent<Animator>().Play("TOP");

            Invoke("SceneChange", 0.88f);
        }
    }
}
