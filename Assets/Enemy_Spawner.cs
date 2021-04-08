using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject obj;
    public GameObject boss;
    private int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.identity;

        rotation.eulerAngles = new Vector3(180, 0, 180);
        int a;
        int b;
        ++counter;

        a = counter % 200;

        b = counter % 2000;

        if(a == 1)
        {
            for(int i = 0; i < 3; i++)
            {
                float randomX = Random.Range(-3f, 3f);
                Instantiate(obj, new Vector3(randomX, 2.0f, 14.0f), rotation);
            }
        }

        if(b == 1)
        {
            Instantiate(boss, new Vector3(0.0f, 2.0f, 14.0f), rotation);
        }
    }
}
