using UnityEngine;

namespace Assets.Scripts
{
    public class MoveCC : IMoving
    {
        public float Speed { get; set; } = 5.0f;
        private float _speedRotation = 3f;
        private float _velociy = 0.0f;
        private float _accelerate = 0.1f;
        private float _decelerate = 0.8f;
        private CharacterController _characterController;

        public MoveCC (GameObject gameObject)
        {
            _characterController = gameObject.GetComponent<CharacterController>();
        }

        public void Move(float Hor, float Vert, Transform transform)
        {
            transform.Rotate(0, Hor * _speedRotation, 0);
            Vector3 forward = transform.TransformDirection(Vector3.forward);

            float curSpeed = Speed * (Vert);
            _characterController.SimpleMove(forward * curSpeed);

            if (curSpeed != 0 || Hor != 0)
            {
                if (_velociy <= 1)
                    _velociy += Time.deltaTime * _accelerate;

                if (_velociy >= 0.3)
                    Speed = 5;
                else
                    Speed = 3;
                Debug.Log("Velociy " + _velociy);
            }
            else
                if (_velociy >= 0)
                _velociy -= Time.deltaTime * _decelerate;
        }

    }
}
