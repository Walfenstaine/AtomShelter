using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dweller : MonoBehaviour
{
    public string dwellerName; // ��� ������
    public int health = 100; // ��������
    public int strength = 1; // ����
    public int agility = 1; // ��������
    public int intelligence = 1; // ���������

    public Room assignedRoom; // �������, � ������� �������� ������

    // ����� ��� ���������� � �������
    public void AssignToRoom(Room room)
    {
        assignedRoom = room;
        transform.position = room.GetWorkPosition(); // ���������� ������ � �������
    }
}