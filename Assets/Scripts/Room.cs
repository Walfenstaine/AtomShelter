using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public Vector2 workPosition; // �������, ��� ����� ������ ������

    // ���������� ������� ��� ������
    public Vector2 GetWorkPosition()
    {
        return (Vector2)transform.position + workPosition;
    }
}