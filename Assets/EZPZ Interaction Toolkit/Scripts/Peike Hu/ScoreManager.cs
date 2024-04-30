using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0; // 存储当前分数
    public AudioSource audioSource; // 音频源组件
    public TextMeshProUGUI scoreText; // 引用UI文本组件

    void Start()
    {
        // 确保音频源组件已经被正确赋值
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        
        Debug.Log("分数已更新到: " + scoreText.text); // 确认更新
    }

    public void AddScore()
    {
        score += 1; // 增加分数
        UpdateScoreText(); // 初始化分数显示
        Debug.Log("当前分数: " + score); // 打印当前分数到控制台

        // 检查分数是否达到6
        if (score >= 6)
        {
            Debug.Log("分数达到6，播放音频!");
            audioSource.Play(); // 播放音频
        }
    }
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score:"+ score; // 设置文本内容显示当前分数
        }
    }
    
}
