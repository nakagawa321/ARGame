using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollision : MonoBehaviour
{
    public SoundManager soundManager = new SoundManager();

    public GameObject Particle;
    private int effectCnt = 0;
    private int scorePoint = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // エフェクト処理
        if ((effectCnt % 10) == 0)
        {
            GameObject hieraruParticle = GameObject.Find("Particle System(Clone)");
            if(hieraruParticle != null) //ヒエラルキーにパーティクルがあるか
            {
                Destroy(hieraruParticle);
            }
        }
        effectCnt++;
    }

    void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown("return"))
        {
            Instantiate(Particle, collision.transform.position, transform.rotation); // エフェクト
            soundManager.playSound4(); // ヒット音
            Destroy(collision.gameObject); // 竹削除
        }

        // android版
        if (Input.touchCount > 0)
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Instantiate(Particle, collision.transform.position, transform.rotation); // エフェクト
                soundManager.playSound4(); // ヒット音
                scoreManager.setScore(scorePoint); // スコア
                Destroy(collision.gameObject); // 竹削除
            }
        }
    }
}
