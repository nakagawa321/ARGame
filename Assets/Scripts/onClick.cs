using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    public SoundManager soundManager = new SoundManager();
    public GameObject startButton;
    public static bool startFlg = false; // ゲームが開始しているか

    // Start is called before the first frame update
    void Start()
    {
        startFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        startFlg = true;
        soundManager.playSound1(); // BGM再生
        soundManager.playSound2(); // 効果音ドン
        Destroy(startButton); // スタートボタン削除
    }
}
