using UnityEngine;

public class AddCharacterController : MonoBehaviour
{
    void Start()
    {
        // �������� �� ��������� CharacterController ��� �����������
        CharacterController controller = GetComponent<CharacterController>();

        // ���� ��������� �������, �� ������ ����
        if (controller == null)
        {
            controller = gameObject.AddComponent<CharacterController>();

            // ������������ ��������� CharacterController, ���� �������
            // ���������, ����� ��������� �� ���� ���������
            controller.height = 2.0f; // ������ ������
            controller.radius = 0.5f; // ������ ����� ���������
            // ���� ���������, �� �� ������ �����������
        }
    }
}
