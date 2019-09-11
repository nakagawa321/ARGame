using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish_scoreManager : MonoBehaviour
{
    public GameObject scoreObject; // Textオブジェクト

    public Text highScoreText; //ハイスコアを表示するText
    private int highScore; //ハイスコア用変数
    private string key = "HIGH SCORE"; //ハイスコアの保存先キー

    // Start is called before the first frame update
    void Start()
    {
        //保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
        highScore = PlayerPrefs.GetInt(key, 0);
        //ハイスコアを表示
        highScoreText.text = "HighScore: " + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //ハイスコアより現在スコアが高い時
        if (scoreManager.getScore() > highScore)
        {
            //ハイスコア更新
            highScore = scoreManager.getScore();

            //ハイスコアを保存
            PlayerPrefs.SetInt(key, highScore);

            //ハイスコアを表示
            highScoreText.text = "HighScore: " + highScore.ToString();       
        }


        // オブジェクトからTextコンポーネントを取得
        Text scoreText = scoreObject.GetComponent<Text>();
        // テキストの表示を入れ替える
        scoreText.text = "Score : " + scoreManager.getScore();

    }

}
