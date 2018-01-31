using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class J3Rotate : MonoBehaviour
{

	public Slider J3Slider;
	public GameObject A3;

	public float J3Angle;

	void Update ()
	{
		J3Angle = J3Slider.value;
		A3.transform.localEulerAngles = new Vector3(-90, 0, J3Angle);

	}

}