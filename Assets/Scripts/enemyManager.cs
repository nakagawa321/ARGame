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
    private int createMin = 50, createMax = 200;
    private float speedMin = 0.01f, speedMax = 0.1f; // 移動スピード
    private Vector3 ramVector = new Vector3(0.0f, 0.0f, 0.0f);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 子として作成
        var parent = bambooes.transform;
        if (onClick.startFlg == true && (enemyOccurrenceCnt % Random.Range(createMin, createMax)) == 0)
        {
            // ランダム値取得
            ramVector.x = Random.Range(-50.0f, 50.0f);
            ramVector.y = Random.Range(-50.0f, 50.0f);
            ramVector.x = Random.Range(-50.0f, 50.0f);

            GameObject obj = Instantiate(bambooPrehab, ramVector/*new Vector3(0.0f, 0.0f, 10.0f)*/, Quaternion.identity, parent); // prehab作成
            obj.name = "bamboo(Clone)" + enemyCreate; // 名前編集
            bamboo[enemyCreate] = GameObject.Find("bamboo(Clone)" + enemyCreate);
            enemyCreate++;
        }
        enemyOccurrenceCnt++;


        // 竹を動かす
        for (int i = 0; i < enemyValue; i++)
        {
            if (bamboo[i] != null)
            {
                //targetの方に少しずつ向きが変わる
                bamboo[i].transform.rotation = Quaternion.Slerp(bamboo[i].transform.rotation, Quaternion.LookRotation(ARCamera.transform.position - bamboo[i].transform.position), 0.3f);

                //targetに向かって進む
                bamboo[i].transform.position += bamboo[i].transform.forward * Random.Range(speedMin, speedMax);
            }
        }

    }

}
