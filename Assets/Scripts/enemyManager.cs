using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public GameObject bambooPrehab;
    public GameObject[] bamboo = new GameObject[100];
    public GameObject bambooes;
    public GameObject ARCamera;
    private int enemyOccurrenceCnt = 0;
    private int enemyCreate = 0;
    private int enemyValue = 100;

    public float speed = 0.1f;//移動スピード

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 子として作成
        var parent = bambooes.transform;
        if (/*onClick.startFlg == true &&*/ (enemyOccurrenceCnt % 100) == 0)
        {
            GameObject obj = Instantiate(bambooPrehab, new Vector3(0.0f, 0.0f, 10.0f), Quaternion.identity, parent); // prehab作成
            bamboo[enemyCreate] = GameObject.Find("bamboo(Clone)");
            enemyCreate++;
        }
        enemyOccurrenceCnt++;


        // 竹を動かす
        for (int i = 0; i < enemyValue; i++) {
            if (bamboo != null)
            {
                //targetの方に少しずつ向きが変わる
                bamboo[i].transform.rotation = Quaternion.Slerp(bamboo[i].transform.rotation, Quaternion.LookRotation(ARCamera.transform.position - bamboo[i].transform.position), 0.3f);

                //targetに向かって進む
                bamboo[i].transform.position += bamboo[i].transform.forward * speed;
            }
        }

    }


    // 竹の配列何番目か数字
    public int getEnemyCreate()
    {
        return this.enemyCreate;
    }

}
