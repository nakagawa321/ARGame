using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    public SoundManager soundManager = new SoundManager();
    public GameObject startButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        soundManager.playSound1(); // BGM再生
        soundManager.playSound2(); // 効果音ドン
        Destroy(startButton); // スタートボタン削除
    }
}
