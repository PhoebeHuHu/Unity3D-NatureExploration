using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0; // �洢��ǰ����
    public AudioSource audioSource; // ��ƵԴ���
    public TextMeshProUGUI scoreText; // ����UI�ı����

    void Start()
    {
        // ȷ����ƵԴ����Ѿ�����ȷ��ֵ
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        
        Debug.Log("�����Ѹ��µ�: " + scoreText.text); // ȷ�ϸ���
    }

    public void AddScore()
    {
        score += 1; // ���ӷ���
        UpdateScoreText(); // ��ʼ��������ʾ
        Debug.Log("��ǰ����: " + score); // ��ӡ��ǰ����������̨

        // �������Ƿ�ﵽ6
        if (score >= 6)
        {
            Debug.Log("�����ﵽ6��������Ƶ!");
            audioSource.Play(); // ������Ƶ
        }
    }
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score:"+ score; // �����ı�������ʾ��ǰ����
        }
    }
    
}
