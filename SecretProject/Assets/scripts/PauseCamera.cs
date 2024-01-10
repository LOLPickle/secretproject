using UnityEngine;

public class PauseCameraControl : MonoBehaviour
{
    private bool cursorLockState = true; // Відстеження стану блокування курсора

    void Update()
    {
        // Перевіряємо, чи натиснута клавіша паузи (Esc)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Інвертуємо стан блокування курсора при кожному натисканні клавіші
            cursorLockState = !cursorLockState;

            // Змінюємо стан блокування курсора в залежності від значення
            Cursor.lockState = cursorLockState ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = !cursorLockState; // Робимо курсор видимим/невидимим залежно від стану блокування
        }
    }
}
