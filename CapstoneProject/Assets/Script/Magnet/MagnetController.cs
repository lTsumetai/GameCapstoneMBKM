using UnityEngine;

namespace magnetship
{
    public class MagnetController : MonoBehaviour
    {

        public float movementSpeed = 5.0f;

        void Start()
        {
            Debug.Log("Start");
        }
        void Update()
        {
            // Updates the position and moves it to the right
            transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
    }
}