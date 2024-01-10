using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    private Transform playerCamera; // Посилання на компонент Transform камери
    private Vector3 savedCameraPosition; // Збережена позиція камери
    private Quaternion savedCameraRotation; // Збережена орієнтація камери

    void Start()
    {
        pauseMenuUI.SetActive(false); // Початково приховуємо меню паузи
        playerCamera = Camera.main.transform; // Отримуємо компонент Transform камери
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                Resume(); // Якщо гра вже на паузі, то продовжуємо гру
            }
            else
            {
                Pause(); // Якщо гра не на паузі, то ставимо її на паузу
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Приховуємо меню паузи
        Time.timeScale = 1f; // Повертаємо швидкість гри до звичайної
        Cursor.lockState = CursorLockMode.Locked; // Фіксуємо курсор
        Cursor.visible = false; // Зробити курсор невидимим

        // Відновлюємо позицію і орієнтацію камери перед паузою
        playerCamera.position = savedCameraPosition;
        playerCamera.rotation = savedCameraRotation;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // Відображаємо меню паузи
        Time.timeScale = 0f; // Ставимо гру на паузу
        Cursor.lockState = CursorLockMode.None; // Розблокуємо курсор
        Cursor.visible = true; // Зробити курсор видимим

        // Зберігаємо позицію і орієнтацію камери перед паузою
        savedCameraPosition = playerCamera.position;
        savedCameraRotation = playerCamera.rotation;
    }

    public void LoadMenu()
    {
        // Додайте код для виходу в головне меню
    }

    public void OpenSettings()
    {
        // Додайте код для відкриття налаштувань
    }
}
