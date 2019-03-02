using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class distance_controlled_camera : MonoBehaviour
{
	[SerializeField]public Transform[] Targets;
	[SerializeField]public float maxDist;
	[SerializeField]public CinemachineVirtualCamera Blending_VCam;

	//public Transform Target_02;
    // Start is called before the first frame update
	void OnDrawGizmos()
	{
		Gizmos.color = new Color(1,0,0,0.5f);
		Gizmos.DrawWireSphere (Targets[0].position,maxDist);
		//Debug.Log ("draw gizmos works!");
	}

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		
		float dist = Vector3.Distance (Targets[0].position, transform.position);
		if (dist <= maxDist) {
			Blending_VCam.Priority = 2;
		}
    }
}
