using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Animations;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] private int animationId;

    private void Start()
    {
        Animator animator = GetComponent<Animator>();
        if (animator == null)
            Destroy(this);

        animator.SetInteger("ID", animationId);

    }
}
