using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public IMoving Moving;

        private void Start()
        {

        }

        public void Move()
        {
            Moving.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform);
        }

    }
}
