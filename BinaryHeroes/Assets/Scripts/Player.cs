using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public Vector2 inputVec;

    public DynamicJoystick joystic;
    
    Rigidbody2D rigid;

    public Scanner scanner;

	private void Awake()
	{
        rigid = GetComponent<Rigidbody2D>();
        scanner = GetComponent<Scanner>();
	}

	void Start()
    {
       
    }

    void Update()
    {
        if (!GameManager.instance.isLive)
            return;

        inputVec.x = joystic.Horizontal;
        inputVec.y = joystic.Vertical;
    }

	private void FixedUpdate()
	{
        if (!GameManager.instance.isLive)
            return;

        Move();
	}


    //�����϶� �̿��ϴ� �Լ�
    void Move()
	{
        // Ű �Է°� ����ȭ * �ӵ�
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;  

        // Ű �Է´�� �����̱�
        rigid.MovePosition(rigid.position + nextVec);


    }
}
