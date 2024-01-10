using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private Transform playerCamera; // ��������� �� ��������� Transform ������
    private Vector3 savedCameraPosition; // ��������� ������� ������
    private Quaternion savedCameraRotation; // ��������� �������� ������

    void Start()
    {
        pauseMenuUI.SetActive(false); // ��������� ��������� ���� �����
        playerCamera = Camera.main.transform; // �������� ��������� Transform ������
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
        Cursor.lockState = CursorLockMode.Locked; // Գ����� ������
        Cursor.visible = false; // ������� ������ ���������

        // ³��������� ������� � �������� ������ ����� ������
        playerCamera.position = savedCameraPosition;
        playerCamera.rotation = savedCameraRotation;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // ³��������� ���� �����
        Time.timeScale = 0f; // ������� ��� �� �����
        Cursor.lockState = CursorLockMode.None; // ���������� ������
        Cursor.visible = true; // ������� ������ �������

        // �������� ������� � �������� ������ ����� ������
        savedCameraPosition = playerCamera.position;
        savedCameraRotation = playerCamera.rotation;
    }

    public void LoadMenu()
    {
        // ������� ��� ��� ������ � ������� ����
    }

    public void OpenSettings()
    {
        // ������� ��� ��� �������� �����������
    }
}
