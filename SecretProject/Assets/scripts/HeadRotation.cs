using UnityEngine;

public class HeadRotation : MonoBehaviour
{
    private Transform headTransform;
    public float rotationSpeed = 3.0f;

    void Start()
    {
        headTransform = transform;
    }

    void Update()
    {
        // �������� �������� ���� ����
        float rotationY = Input.GetAxis("Mouse Y");
        float rotationX = Input.GetAxis("Mouse X");

        // ��������� ������
        Vector3 currentRotation = headTransform.localEulerAngles;

        float newRotationX = currentRotation.y + rotationX * rotationSpeed;
        float newRotationY = currentRotation.x - rotationY * rotationSpeed;

        headTransform.localEulerAngles = new Vector3(
            newRotationY,
            newRotationX,
            0f
        );
    }
}
