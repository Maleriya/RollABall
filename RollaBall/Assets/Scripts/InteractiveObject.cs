using UnityEngine;

namespace Assets.Scripts
{
    public abstract class InteractiveObject : MonoBehaviour, IInteractable
    {
        protected Color _color;
        public bool IsInteractable { get; } = true;
        protected abstract void Interaction();

        private void Start()
        {
            Action();
        }

        public void Action()
        {
            _color = Random.ColorHSV();
            if (TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = _color;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!IsInteractable || !other.CompareTag("Player"))
            {
                return;
            }
            Interaction();
            Destroy(gameObject);
        }

    }

}
