namespace Assets.Scripts
{
    public sealed class PlayerBallCC : Player
    {
        private void Start()
        {
            Moving = new MoveCC(gameObject);
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}
