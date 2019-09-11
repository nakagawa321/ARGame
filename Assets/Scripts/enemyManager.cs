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
    private int createMin = 50, createMax = 80;
    private float speedMin = 0.05f, speedMax = 1.0f; // 移動スピード
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
            ramVector.x = Random.Range(-7.0f, 7.0f);
            ramVector.y = Random.Range(-10.0f, 0.0f);
            ramVector.z = Random.Range(20.0f, 40.0f);

            GameObject obj = Instantiate(bambooPrehab, ramVector, Quaternion.identity, parent); // prehab作成
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

    // 竹の数
    public int get_enemyCreate()
    {
        return this.enemyCreate;
    }
}
