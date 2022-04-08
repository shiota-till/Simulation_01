using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    int nowIndex;

    void Update()
    {
        //目的地を探す
        GameObject target = GameObject.Find("Point" + (nowIndex + 1));


        //見つかったら実行
        if (target != null)
        {
            //目的地への向き
            Vector3 direction = (target.transform.position - transform.position).normalized;

            //移動
            transform.Translate(direction * 0.01f);

            //到着チェック
            if (Vector3.Distance(target.transform.position, transform.position) < 1)
            {
                nowIndex++;
            }
        }
    }
}