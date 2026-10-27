using UnityEngine;

public class playerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    CharacterController controller;
    Vector3 playerVelocity;
    bool groundedPlayer;
    float playerSpeed;
    float gravityValue;
    gameObject activeChar;
    float moveHorizontal;
    float moveVertical;
    float speed = 4;
    float rotateSpeed = 4;
    float jumpHeight = 1.2f;

    void Start()
    {
        gravitySpeed = 4;
        gravityValue = -20;
    }

    // Update is called once per frame
    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if(groundedPlayer && playerVelocity.y < 0){
            playerVelocity.y = 0;
        }
        transform.Rotate(0, input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * input.GetAxis("Vertical");
        controller.SimpleMove(forward * curspeed);
        if (input.GetButtonDown("Jump") && groundedPlayer){
            isJumping = true;
            activeChar.GetComponent<Animator>().play("Jump");
            playerVelocity.y += 10;

        }
    }
}
