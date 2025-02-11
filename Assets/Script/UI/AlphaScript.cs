﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlphaScript : MonoBehaviour {
    public Text Qtext;
    float a_color;
    bool flag_G;
    // Use this for initialization
    void Start()
    {
        a_color = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "TitleScene")
        {
            //テキストの透明度を変更する
            Qtext.color = new Color(0, 0, 0, a_color);
            if (flag_G)
                a_color -= Time.deltaTime;
            else
                a_color += Time.deltaTime;
            if (a_color < 0)
            {
                a_color = 0;
                flag_G = false;
            }
            else if (a_color > 1)
            {
                a_color = 1;
                flag_G = true;
            }
        }
    }
}
