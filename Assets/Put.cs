using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Put : MonoBehaviour
{

    public GameObject routePoint;
    int index = 0;

    void Update()
    {
        //�}�E�X�̃{�^���������ꂽ����s
        if (Input.GetMouseButtonDown(0))
        {

            //�����΂��n�_�A�������J�������狁�߂�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //�q�b�g��������ϐ���p��
            RaycastHit hitInfo;

            //�����΂�
            Physics.Raycast(ray, out hitInfo);

            //�����Ԃ���������s
            if (hitInfo.collider != null)
            {
                //�v���t�@�u�𐶐�
                var instance = Instantiate(routePoint);

                //���W��ύX
                instance.transform.position = hitInfo.point;

                //���O��ς���
                instance.name = "Point" + index;
                index++;
            }

        }
    }
}