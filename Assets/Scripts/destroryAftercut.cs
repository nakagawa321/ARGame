using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroryAftercut : MonoBehaviour
{
    public GameObject aftercut;
    private int destroyCount = 0;
    private int aftercutSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyCount > aftercutSpeed)
        {
            Destroy(aftercut);
        }
        destroyCount++;

    }
}
