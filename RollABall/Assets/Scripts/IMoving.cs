using UnityEngine;

namespace Assets.Scripts
{
    public interface IMoving
    {
        float Speed { get; set; }

        void Move(float Hor, float Vert, Transform transform);
    }
}
