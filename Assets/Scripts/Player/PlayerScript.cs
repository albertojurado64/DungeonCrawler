using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float moveSpeed = 5f;
    private CharacterController chController;


    void Start()
    {
        chController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
       

        Vector3 input = new Vector3(Horizontal, 0, Vertical);
        input = Vector3.ClampMagnitude(input, 1);

        Vector3 targetVelocity = input * moveSpeed;

       

        chController.Move( input * Time.deltaTime * moveSpeed);
    }
}
