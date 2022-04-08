using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    int nowIndex;

    void Update()
    {
        //�ړI�n��T��
        GameObject target = GameObject.Find("Point" + (nowIndex + 1));


        //������������s
        if (target != null)
        {
            //�ړI�n�ւ̌���
            Vector3 direction = (target.transform.position - transform.position).normalized;

            //�ړ�
            transform.Translate(direction * 0.01f);

            //�����`�F�b�N
            if (Vector3.Distance(target.transform.position, transform.position) < 1)
            {
                nowIndex++;
            }
        }
    }
}