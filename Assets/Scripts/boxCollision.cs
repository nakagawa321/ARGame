using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollision : MonoBehaviour
{
    public SoundManager soundManager = new SoundManager();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown("return"))
        {
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
                soundManager.playSound4(); // ヒット音
                Destroy(collision.gameObject); // 竹削除
            }
        }
    }
}
