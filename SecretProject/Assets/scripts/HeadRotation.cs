using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    private Transform headTransform;
    public float rotationSpeed = 3.0f;
    private bool isCameraActive = true; // Флаг, що визначає, чи активна реакція камери на мишу

    void Start()
    {
        headTransform = transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleCameraActivity(); // Перемикач активності камери при натисканні клавіші "Esc"
        }

        if (isCameraActive)
        {
            // Отримання значень руху миші
            float rotationY = Input.GetAxis("Mouse Y");
            float rotationX = Input.GetAxis("Mouse X");

            // Обробка руху камери за допомогою миші
            Vector3 currentRotation = headTransform.localEulerAngles;

            float newRotationX = currentRotation.y + rotationX * rotationSpeed;
            float newRotationY = currentRotation.x - rotationY * rotationSpeed;

            headTransform.localEulerAngles = new Vector3(newRotationY, newRotationX, 0f);
        }
    }

    void ToggleCameraActivity()
    {
        isCameraActive = !isCameraActive; // Зміна стану флага

        // Якщо реакція камери на мишу вимкнена, зупиніть рух камери
        if (!isCameraActive)
        {
            Cursor.lockState = CursorLockMode.None; // Розблокувати курсор
            Cursor.visible = true; // Зробити курсор видимим
        }
    }
}
