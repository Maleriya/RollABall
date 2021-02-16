using UnityEngine;

namespace Assets.Scripts
{
    internal class MoveRB : IMoving
    {
        public float Speed { get; set; } = 5.0f;
        private Rigidbody _rigidbody;

        public MoveRB(GameObject gameObject)
        {
            _rigidbody = gameObject.GetComponent<Rigidbody>();
        }

        public void Move(float Hor, float Vert, Transform transform)
        {
            Vector3 movement = new Vector3(Hor, 0.0f, Vert);

            _rigidbody.AddForce(movement * Speed);
        }
    }
}
