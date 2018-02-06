using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {


	public AnimationClip anim_to_play;
	Animation anim;
	Animator an;

	void Start() {
		anim = GetComponent<Animation>();
	}

	void Update () {
		if (Input.GetKey(KeyCode.W)){
			anim.clip = anim_to_play;
			anim.Play();        

		}
	}
}
