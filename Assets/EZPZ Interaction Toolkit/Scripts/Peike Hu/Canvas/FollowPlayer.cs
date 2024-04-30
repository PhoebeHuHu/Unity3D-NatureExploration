using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform playerTransform; // ��ҵ� Transform ���
    public Vector3 offset; // Canvas �������ҵ�ƫ����

    void LateUpdate()
    {
        // �����ҵ� Transform �������
        if (playerTransform != null)
        {
            // ������������λ�õ�ƫ����
            Vector3 relativeOffset = playerTransform.rotation * offset;

            // ���� Canvas ��λ��Ϊ��ҵ�λ�ü���ƫ����
            transform.position = playerTransform.position + relativeOffset;

            // �� Canvas ʼ�����������
            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        }
    }
}

