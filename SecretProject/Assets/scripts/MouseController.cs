using UnityEngine;

public class MouseLock : MonoBehaviour
{
    private bool isCursorLocked = true;

    void Start()
    {
        LockCursor();
    }

    void Update()
    {
        // ��� ��������� ������ Esc ������������/������ ���������� �������
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isCursorLocked = !isCursorLocked;
            if (isCursorLocked)
            {
                LockCursor();
            }
            else
            {
                UnlockCursor();
            }
        }
    }

    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked; // ����������� ������
        Cursor.visible = false; // ������� ������ ���������
    }

    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None; // ������������ ������
        Cursor.visible = true; // ������� ������ �������
    }
}
