using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cutManager : MonoBehaviour
{
    public SoundManager SoundManager;
    public GameObject AfterCutUI;
    public GameObject afterCut_left;
    public GameObject afterCut_right;
    private Vector3 aftercutTransform = new Vector3(1100.0f, 500.0f, 0.0f);

    bool stateAftercut = false;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 斬跡をprefaabから子として作成
        var parent = AfterCutUI.transform;
        // android版
        if (Input.touchCount > 0)
        {
            // タッチ情報の取得
            Touch touch = Input.GetTouch(0);
            if (onClick.startFlg == true && touch.phase == TouchPhase.Began)
            {
                SoundManager.playSound3(); // 斬跡音
                if (stateAftercut == false)
                {
                    GameObject obj = Instantiate(afterCut_left, aftercutTransform, Quaternion.identity, parent); // 斬り後左表示
                    stateAftercut = true;
                }
                else
                {
                    GameObject obj = Instantiate(afterCut_right, aftercutTransform, Quaternion.identity, parent); // 斬り後左表示
                    stateAftercut = false;
                }
            }
        }
    }
}
