using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // パソコン版
        if (Input.GetKeyDown("return") && SceneManager.GetActiveScene().name == "StartScene")
        {
            SceneManager.LoadScene("GameMain");
        }
        // android版
        if (Input.touchCount > 0 && SceneManager.GetActiveScene().name == "StartScene")
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                SceneManager.LoadScene("GameMain");
            }

        }
    }
}
