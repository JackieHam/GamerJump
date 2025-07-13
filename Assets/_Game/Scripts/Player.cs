using UnityEngine;
using UnityEngine.InputSystem;

namespace _Game.Scripts
{
    public class Player : MonoBehaviour
    {
        public Rigidbody2D rb;
        
        private void Start()
        {
            
        }

        private void Update()
        {
            
            //float horiz = Input.GetAxisRaw("Horizontal");
            
            //rb.linearVelocityX += horiz * 10;

            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                rb.linearVelocityY = 5;
            }
        }
    }
}
