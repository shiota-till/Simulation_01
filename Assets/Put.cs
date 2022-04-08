using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put : MonoBehaviour
{

    public GameObject routePoint;
    int index = 0;

    void Update()
    {
        //マウスのボタンが押されたら実行
        if (Input.GetMouseButtonDown(0))
        {

            //線を飛ばす地点、向きをカメラから求める
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //ヒット情報を入れる変数を用意
            RaycastHit hitInfo;

            //線を飛ばす
            Physics.Raycast(ray, out hitInfo);

            //何かぶつかったら実行
            if (hitInfo.collider != null)
            {
                //プレファブを生成
                var instance = Instantiate(routePoint);

                //座標を変更
                instance.transform.position = hitInfo.point;

                //名前を変える
                instance.name = "Point" + index;
                index++;
            }

        }
    }
}