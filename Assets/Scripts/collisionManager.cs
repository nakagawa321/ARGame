using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManager : MonoBehaviour
{
    public SoundManager soundManager = new SoundManager();
    public GameObject Particle;

    private int scorePoint = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    // ヒット時の処理
    public void boxCollision(Collision collision)
    {
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

    // ダメージ時処理
    public void bambooCollision(Collision collision)
    {
        scoreManager.setScore(-scorePoint); // スコア
        Destroy(collision.gameObject); // 竹削除
    }

}
