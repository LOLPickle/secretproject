using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false); // ��������� ��������� ���� �����
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                Resume(); // ���� ��� ��� �� ����, �� ���������� ���
            }
            else
            {
                Pause(); // ���� ��� �� �� ����, �� ������� �� �� �����
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // ��������� ���� �����
        Time.timeScale = 1f; // ��������� �������� ��� �� ��������
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // ³��������� ���� �����
        Time.timeScale = 0f; // ������� ��� �� �����
    }

    //public void LoadMenu()
    //{
        // ������� ��� ��� ������ � ������� ����
    //}

    //public void OpenSettings()
    //{
        // ������� ��� ��� �������� �����������
    //}
}
