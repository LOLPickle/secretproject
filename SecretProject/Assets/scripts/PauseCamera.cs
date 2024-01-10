using UnityEngine;

public class PauseCameraControl : MonoBehaviour
{
    private bool cursorLockState = true; // ³��������� ����� ���������� �������

    void Update()
    {
        // ����������, �� ��������� ������ ����� (Esc)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ��������� ���� ���������� ������� ��� ������� ��������� ������
            cursorLockState = !cursorLockState;

            // ������� ���� ���������� ������� � ��������� �� ��������
            Cursor.lockState = cursorLockState ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = !cursorLockState; // ������ ������ �������/��������� ������� �� ����� ����������
        }
    }
}
