using UnityEngine;
using System.Collections;

//GetComponent<Rigidbody> ().velocity = movement * speed;


public class RandomRotator : MonoBehaviour {

	public float tumble;

	void Start()
	{
		GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * tumble;
	}

}
