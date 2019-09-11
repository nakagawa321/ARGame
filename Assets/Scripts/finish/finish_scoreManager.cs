using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish_scoreManager : MonoBehaviour
{
    public GameObject scoreObject; // Textオブジェクト

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text scoreText = scoreObject.GetComponent<Text>();
        // テキストの表示を入れ替える
        scoreText.text = "Score : " + scoreManager.getScore();

    }
}
