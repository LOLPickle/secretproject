using UnityEngine;

public class AddCharacterController : MonoBehaviour
{
    void Start()
    {
        // Перевірка чи компонент CharacterController вже прикріплений
        CharacterController controller = GetComponent<CharacterController>();

        // Якщо компонент відсутній, то додаємо його
        if (controller == null)
        {
            controller = gameObject.AddComponent<CharacterController>();

            // Налаштування параметрів CharacterController, якщо потрібно
            // Наприклад, розмір колайдера та інші параметри
            controller.height = 2.0f; // Задати висоту
            controller.radius = 0.5f; // Задати радіус колайдера
            // Інші параметри, які ви хочете налаштувати
        }
    }
}
