using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics; // 終了処理に必要
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 初めから
    public void onClick_restart()
    {
        SceneManager.LoadScene("StartScene");
    }

    // 終了
    public void onClick_finish()
    {
        Utils.ForceCrash(ForcedCrashCategory.AccessViolation);
    }

}
