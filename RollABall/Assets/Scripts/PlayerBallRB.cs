using UnityEngine;

namespace Assets.Scripts
{
    public sealed class PlayerBallRB : Player
    {
        private void Start()
        {
            Moving = new MoveRB(gameObject);
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}
