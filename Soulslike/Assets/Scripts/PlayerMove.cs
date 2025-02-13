using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    Input_Controls inputs;
    Rigidbody2D myRb;

    [Header("Player_Setting")]
    [SerializeField] float playerSpeed = 0;
    [SerializeField] float jumpForce = 0;

    [Header("Bool_Control")]
    [SerializeField] bool isMove = false;
    [SerializeField] bool isGround = false;

    [SerializeField] bool isRightFace = false;

 

    float direction = 0;


    private void Awake()
    {
        inputs = new Input_Controls();

        inputs.Game_Play.Right_Move.performed += ctx => RightMoveBtn();
        inputs.Game_Play.Left_Move.performed += ctx => LeftMoveBtn();

        inputs.Game_Play.Right_Move.canceled += ctx => NotMove("right");
        inputs.Game_Play.Left_Move.canceled += ctx => NotMove("left");

        inputs.Game_Play.Jump.started += ctx => JumpMoveBtn();

      //  inputs.Game_Play.Shadow_Point.started += ctx => TeleportPointBtn();

       // inputs.Game_Play.Teleporter.started += ctx => TeleportationBtn();

    }
    private void OnEnable()
    {
        inputs.Enable();
    }
    void Start()
    {
        FindAll();
    }
    void FindAll()
    {
        myRb = GetComponent<Rigidbody2D>();
    }
    void RightMoveBtn()
    {
        direction = 1;
        isMove = true;
    }
    void LeftMoveBtn()
    {
        direction = -1;
    }
    void NotMove(string directionKey)
    {
        if (directionKey == "right" && inputs.Game_Play.Left_Move.ReadValue<float>() > 0)
        {
            direction = -1;
            return;
        }

        // Eðer sol tuþu býraktýysan ama sað tuþu hala basýlý tutuyorsan, durma.
        if (directionKey == "left" && inputs.Game_Play.Right_Move.ReadValue<float>() > 0)
        {
            direction = 1;
            return;
        }


      
        if (direction != 0)
        {
            direction = 0;
            myRb.linearVelocity = new Vector3((playerSpeed * direction), myRb.linearVelocity.y);
        }
    }
    void JumpMoveBtn()
    {
        if (isGround)
        {
            Jump();
        }
    }
   
    void Update()
    {
        Movement();
        GroundControl();
    }
    private void LateUpdate()
    {
        if (direction == 0 && myRb.linearVelocity.x != 0)
        {
            myRb.linearVelocity = new Vector2(0, myRb.linearVelocity.y);
        }
    }
    void Movement()
    {

        if (isRightFace == true && direction == 1)
        {
            Flip();

        }

        else if (isRightFace == false && direction == -1)
        {
            Flip();

        }

        if (direction != 0)
        {
            myRb.linearVelocity = new Vector3((playerSpeed * direction), myRb.linearVelocity.y);
        }

    }
    void Flip()
    {
        isRightFace = !isRightFace;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }
    void Jump()
    {
        myRb.linearVelocity = Vector2.up * jumpForce;
    }
 

    void GroundControl()
    {
        Debug.DrawRay(transform.position, Vector2.down * 1.5f, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.5f, 1 << 6);

        if (hit.collider != null)
        {
            isGround = true;

        }
        else
        {
            isGround = false;
        }

    }

    private void OnDisable()
    {
        inputs.Disable();
    }
}
