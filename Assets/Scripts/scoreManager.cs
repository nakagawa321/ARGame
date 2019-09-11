using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    public enemyManager enemyManager = new enemyManager();
    public static int Score = 0;
    private int limitBamboo = 21;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // たけが多くなると
        if(enemyManager.get_enemyCreate() > limitBamboo)
        {
            // 終了
            SceneManager.LoadScene("FinishScene");
        }
    }

    // スコアセッター
    public static void setScore(int score)
    {
        Score += score;
    }

    // スコア(シーン間共有)
    public static int getScore()
    {
        return Score;
    }

}
