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
        // При натисканні клавіші Esc встановлюємо/знімаємо блокування курсора
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
        Cursor.lockState = CursorLockMode.Locked; // Зафіксувати курсор
        Cursor.visible = false; // Зробити курсор невидимим
    }

    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None; // Розблокувати курсор
        Cursor.visible = true; // Зробити курсор видимим
    }
}
