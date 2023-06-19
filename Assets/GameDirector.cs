using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel; // ������\������UI-Text�I�u�W�F�N�g��ۑ�����ϐ�
    int kyori;              // ������ۑ�����ϐ�

    public Image timeGauge; // �^�C���Q�[�W��\������UI

    public static float lastTime;         // �c�莞�Ԃ�ۑ�����ϐ�

    void Start()
    {
        kyori = 0;
        lastTime = 100f; // �c�莞��100�b
    }

    void Update()
    {
        // �c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        // �c�莞�Ԃ�0�ɂȂ����烊���[�h
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }

        // �i�񂾋�����\��
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "km";
    }
}
