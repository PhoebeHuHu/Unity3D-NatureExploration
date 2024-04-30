using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform playerTransform; // 玩家的 Transform 组件
    public Vector3 offset; // Canvas 相对于玩家的偏移量

    void LateUpdate()
    {
        // 如果玩家的 Transform 组件存在
        if (playerTransform != null)
        {
            // 计算相对于玩家位置的偏移量
            Vector3 relativeOffset = playerTransform.rotation * offset;

            // 设置 Canvas 的位置为玩家的位置加上偏移量
            transform.position = playerTransform.position + relativeOffset;

            // 让 Canvas 始终面向摄像机
            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);
        }
    }
}

