using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //variables se escriben en camelCase
    //los metodos, clases y funciones en PascalCase
    GameObject player;
    Rigidbody rb;
    Animator anim;
    private Vector3 movementDirection;
    [SerializeField] private float horizontalMovement;
    [SerializeField] private float forwardMovement;
    [SerializeField] private float movementVelocity = 15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementDirection = new Vector3(horizontalMovement, 0, forwardMovement);
    }

    void Awake() //se ejecuta si el personaje se activa en la escena.
    {
        
    }

    void FixedUpdate() //es un update que se ejecuta SI O SI 100/segundo. Es la frecuencia con la que se actualiza el sistema de fisicas.
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        forwardMovement = Input.GetAxis("Vertical");
        movementDirection = new Vector3(horizontalMovement, 0, forwardMovement);
    }

    void LateUpdate() // 100 HZ
    {
        rb.AddForce(movementDirection*movementVelocity, ForceMode.Acceleration);
        /*
        ForceMode.Acceleration; aceleracion constante - coche
        ForceMode.Impulse; da un solo impulso - si me empujan en hielo
        ForceMode.VelocityChange; cambia la velocidad del rb -- se establece una velocidd
        ForceMode.Force; añade una fuerza -- le dan un empujon
        */
    }
}
