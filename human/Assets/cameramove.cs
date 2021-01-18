using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject MainCamera; //аттач главной камеры для получения вектора направления движения
    public GameObject Player; //Объект игрок

    public static bool _gameover; //условие проигрыша

    private float speed; //Скорость перемещения
    private Rigidbody rb; //Физическое тело
    private bool grounded; // На земле ли персонаж?
    private bool moveForward; // Двигается вперед персонаж?

    private float posx, posy, posz, posyyy = 6.0f;
    //Задаем переменные при старте игры
    void Start()
    {
        grounded = true;
        rb = Player.GetComponent<Rigidbody>();
        _gameover = false;
        speed = 300;
        moveForward = false;
    }

    //Теперь опишем, что должен делать персонаж при нажатых клавишах

    void Update()
    {
        //Двигаемся вперед по вектору камеры
        if (Input.GetMouseButton(0) & _gameover == false)
        {
            GetComponent<Rigidbody>().isKinematic = false;
            moveForward = true;
            if (grounded == true)
            {
                rb.AddForce(MainCamera.transform.forward * speed * Time.deltaTime);
            }
            else
            {
                rb.AddForce(0f, 0f, 0f);
            }
        }
        else
        {
            moveForward = false;

            posx = Player.transform.position.x;
            posy = Player.transform.position.y;
            posz = Player.transform.position.z;

            transform.position = new Vector3(posx, posy, posz);

            GetComponent<Rigidbody>().isKinematic = true;

        }
        posx = Player.transform.position.x;
        posz = Player.transform.position.z;
        transform.position = new Vector3(posx, posyyy, posz);
    }
}

