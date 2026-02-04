using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;
    public float jumpUp = 1;
    public Vector3 direction;

    Animator pAnimator;
    Rigidbody2D pRigidbody;
    SpriteRenderer sp;
    void Start()
    {
        pAnimator = GetComponent<Animator>();   //애니메이터 컴포넌트 가져오기
        pRigidbody = GetComponent<Rigidbody2D>();   //리지드바디 컴포넌트 가져오기
        sp = GetComponent<SpriteRenderer>();        //스프라이트 렌더러 컴포넌트 가져오기
        direction = Vector2.zero;   //방향 초기화



        


    }

    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal");   // -1, 0, 1 이렇게 딱 떨어진다.
        //이렇게 잡은 이유는 플립을 할거라서.

        if(direction.x <0)
        {
            //왼쪽으로 이동
            sp.flipX = true;
        }

        else if(direction.x >0)
        {
            //오른쪽으로 이동
            sp.flipX = false;
        }

        else if(direction.x ==0)
        {
            //정지

        }
    }

    void Update()
    {
        KeyInput();

        //플레이어 이동
        //오른쪽 이동 = 현재 위치 + 속도 * 방향 * 시간
        transform.position += Vector3.right * speed * direction.x * Time.deltaTime;

    }
}
