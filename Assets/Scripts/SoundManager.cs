using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource GameMain;
    public AudioSource play_GameMain; // メイン音
    public AudioClip Don;
    public AudioClip afterCut;

    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        GameMain = GetComponent<AudioSource>();

        // どちらかがnullになるので修正
        if (GameMain == null)
        {
            GameMain = play_GameMain;
        }
        if (play_GameMain == null)
        {
            play_GameMain = GameMain;
        }

    }

    // Update is called once per frame
    void Update()
    {
    }

    // ゲームメイン音
    public void playSound1()
    {
        play_GameMain.Play();
    }
    // 太鼓音
    public void playSound2()
    {
        GameMain.PlayOneShot(Don);
    }
    // 斬跡音
    public void playSound3()
    {
        GameMain.PlayOneShot(afterCut);
    }
}
