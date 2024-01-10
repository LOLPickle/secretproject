using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 3.0f;
    public float sprintSpeedMultiplier = 2.0f;
    public float jumpForce = 8.0f; // ���� ������

    private CharacterController controller;
    private Transform characterTransform;
    private Vector3 moveDirection = Vector3.zero;
    private bool isGrounded; // ����� ��� ��������, �� �������� �� ����

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

        // ��������, �� �������� �� ����
        isGrounded = controller.isGrounded;

        // ������ ���������, ���� �������� �� �� ����
        if (!isGrounded)
        {
            moveDirection.y -= 9.81f * Time.deltaTime;
        }

        // ������
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

        // ��� ���������
        controller.Move(moveDirection * Time.deltaTime);

        // ��������� ������ �� ��������� ����
        float rotationX = Input.GetAxis("Mouse X") * rotationSpeed;
        characterTransform.Rotate(0, rotationX, 0);
    }
}
