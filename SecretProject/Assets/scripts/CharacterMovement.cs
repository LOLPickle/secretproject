using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 3.0f;
    public float sprintSpeedMultiplier = 2.0f;
    public float jumpForce = 8.0f; // Сила прижка

    private CharacterController controller;
    private Transform characterTransform;
    private Vector3 moveDirection = Vector3.zero;
    private bool isGrounded; // Змінна для перевірки, чи персонаж на землі

    void Start()
    {
        controller = GetComponent<CharacterController>();
        characterTransform = transform;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = characterTransform.TransformDirection(new Vector3(moveHorizontal, 0.0f, moveVertical));
        moveDirection.x = move.x * movementSpeed;
        moveDirection.z = move.z * movementSpeed;

        // Перевірка, чи персонаж на землі
        isGrounded = controller.isGrounded;

        // Додамо гравітацію, якщо персонаж не на землі
        if (!isGrounded)
        {
            moveDirection.y -= 9.81f * Time.deltaTime;
        }

        // Прижок
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

        // Sprint
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection.x *= sprintSpeedMultiplier;
            moveDirection.z *= sprintSpeedMultiplier;
        }

        // Рух персонажа
        controller.Move(moveDirection * Time.deltaTime);

        // Обертання голови за допомогою миші
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed;
        characterTransform.Rotate(0, rotationX, 0);
    }
}
