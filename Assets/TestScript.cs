using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	public ParticleSystem ps;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World");
		SetupParticles();
	}
		
	void SetupParticles() {
		var em = ps.emission;
		var main = ps.main;
		main.duration = 1;
		main.loop = true;
		main.startLifetime = 1;
	}
		
	// Update is called once per frame
	void Update () {
		var em = ps.emission;
		SetHighParticleRate();
	}

	void EnableParticles() {
		var em = ps.emission;
		em.enabled = true;
	}

	void DisableParticles() {
		var em = ps.emission;
		em.enabled = false;
	}

	void SetLowParticleRate() {
		var em = ps.emission;
		em.enabled = true;
		em.rateOverTimeMultiplier = 400f;
	}

	void SetHighParticleRate() {
		var em = ps.emission;
		em.enabled = true;
		em.rateOverTimeMultiplier = 4000;
	}

	void SetParticleIntensity(float intensity) {
		var em = ps.emission;
		em.enabled = true;
		float maxVal = 5000f;
		em.rateOverTimeMultiplier = maxVal * intensity;
	}

}
