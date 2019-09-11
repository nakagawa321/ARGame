using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollision : MonoBehaviour
{
    public collisionManager collisionManager = new collisionManager();

    public GameObject Particle;
    private int effectCnt = 0;

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
        collisionManager.boxCollision(collision); // コリジョンマネージャーへ
    }
}
