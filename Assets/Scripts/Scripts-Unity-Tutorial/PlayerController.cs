using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;

    public KeyCode switchKey;
    public Camera mainCamera;
    public Camera hoodCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get the user input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // transform.Translate(0, 0, 1 * Time.deltaTime);
        // transform.Translate(Vector3.forward);
        // NÃO SERVE MAIS: PORQUE O OBJETO VAI CAMINHAR SEMPRE EM FRENTE -> transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // NÃO SERVE MAIS: PORQUE O OBJETO NÃO PRECISA CAMINHAR PROS LADOS, APENAS A ROTAÇÃO É ÚTIL -> transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
