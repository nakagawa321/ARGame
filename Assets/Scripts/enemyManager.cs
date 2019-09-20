using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    public GameObject bambooPrehab;
    public GameObject[] bamboo = new GameObject[100];
    public GameObject bambooes;
    public GameObject damageBox;
    private int enemyOccurrenceCnt = 0;
    private int enemyCreate = 0;
    private int enemyValue = 100;
    private int createMin = 25, createMax = 50;
    private int careteValue = 50;
    private float speedMin = 0.05f, speedMax = 1.0f; // 移動スピード
    private Vector3 ramVector = new Vector3(0.0f, 0.0f, 0.0f);
    private float ramVectorMin_x = -7.0f, ramVectorMax_x = 7.0f; // 座標xランダム数
    private float ramVectorMin_y = -10.0f, ramVectorMax_y = 0.0f; // 座標yランダム数
    private float ramVectorMin_z = 20.0f, ramVectorMax_z = 40.0f; // 座標zランダム数



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 子として作成
        var parent = bambooes.transform;
        if (onClick.startFlg == true && (enemyOccurrenceCnt % careteValue) == 0)
        {
            // ランダム値取得
            ramVector.x = Random.Range(ramVectorMin_x, ramVectorMax_x);
            ramVector.y = Random.Range(ramVectorMin_y, ramVectorMax_y);
            ramVector.z = Random.Range(ramVectorMin_z, ramVectorMax_z);

            GameObject obj = Instantiate(bambooPrehab, ramVector, Quaternion.identity, parent); // prehab作成
            obj.name = "bamboo(Clone)" + enemyCreate; // 名前編集
            bamboo[enemyCreate] = GameObject.Find("bamboo(Clone)" + enemyCreate);
            enemyCreate++;
            careteValue = Random.Range(createMin, createMax); // ランダム出現数取得
            enemyOccurrenceCnt = 0; // ランダムカウントリセット
        }
        enemyOccurrenceCnt++;


        // 竹を動かす
        for (int i = 0; i < enemyValue; i++)
        {
            if (bamboo[i] != null)
            {
                //targetの方に少しずつ向きが変わる
                bamboo[i].transform.rotation = Quaternion.Slerp(bamboo[i].transform.rotation, Quaternion.LookRotation(damageBox.transform.position - bamboo[i].transform.position), 0.3f);

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
