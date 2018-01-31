using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class J1Rotate : MonoBehaviour
{

	public Slider J1Slider;
	public GameObject A1;
	public float J1Angle;

	void Update ()
	{
		J1Angle = J1Slider.value;
		A1.transform.localEulerAngles = new Vector3(0 , 0, J1Angle);

		}





}
