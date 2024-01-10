using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    void Start()
    {
        pauseMenuUI.SetActive(false); // Початково приховуємо меню паузи
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
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // Відображаємо меню паузи
        Time.timeScale = 0f; // Ставимо гру на паузу
    }

    //public void LoadMenu()
    //{
        // Додайте код для виходу в головне меню
    //}

    //public void OpenSettings()
    //{
        // Додайте код для відкриття налаштувань
    //}
}
