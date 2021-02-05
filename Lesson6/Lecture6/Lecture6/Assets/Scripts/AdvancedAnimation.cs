using UnityEngine;

public class AdvancedAnimation : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Animator _animator;

    private void FixedUpdate()
    {
        _animator.SetFloat("horizontal", _rigidbody.velocity.x);
        _animator.SetFloat("vertical", _rigidbody.velocity.z);
    }
}