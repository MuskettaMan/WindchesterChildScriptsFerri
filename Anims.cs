using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anims : MonoBehaviour {

    public enum AnimState {
        IdleFront,
        IdleBack,
        IdleLeft,
        IdleRight,
        WalkFront,
        WalkBack,
        WalkLeft,
        WalkRight
    }

    public enum Facing {
        Front,
        Back,
        Left,
        Right
    }

    private Animator animator;
    private Rigidbody2D rb2d;

    private Facing faceDirection;

    private void Start() {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {

        if(rb2d.velocity.y < 0) {
            ChangeAnimationState(AnimState.WalkFront);
            faceDirection = Facing.Front;
        } else if(rb2d.velocity.y > 0) {
            ChangeAnimationState(AnimState.WalkBack);
            faceDirection = Facing.Back;
        } else if(rb2d.velocity.x < 0) {
            ChangeAnimationState(AnimState.WalkLeft);
            faceDirection = Facing.Left;
        } else if(rb2d.velocity.x > 0) {
            ChangeAnimationState(AnimState.WalkRight);
            faceDirection = Facing.Right;
        }

        if(rb2d.velocity == Vector2.zero) {
            switch(faceDirection) {
                case Facing.Front:
                ChangeAnimationState(AnimState.IdleFront);
                break;

                case Facing.Back:
                ChangeAnimationState(AnimState.IdleBack);
                break;

                case Facing.Left:
                ChangeAnimationState(AnimState.IdleLeft);
                break;

                case Facing.Right:
                ChangeAnimationState(AnimState.IdleRight);
                break;

                default:
                ChangeAnimationState(AnimState.IdleFront);
                break;
            }
        }       

    }

    private void ChangeAnimationState(AnimState state) {
        animator.SetInteger("AnimState", (int)state);
    }

}
