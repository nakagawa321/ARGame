using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bambooCollision : MonoBehaviour
{
    public collisionManager collisionManager = new collisionManager();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        collisionManager.bambooCollision(collision); //コリジョンマネージャへ
    }
}
