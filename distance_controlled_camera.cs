using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class distance_controlled_camera_v1 : MonoBehaviour
{
	[SerializeField]public Transform[] Targets;
	[SerializeField]public float MixDist;
//	[SerializeField]public CinemachineVirtualCamera MixVCam;

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
		float PlayerWeight = dist / maxDist;
		if (dist <= maxDist) {
			GetComponent<CinemachineMixingCamera> ().m_Weight0 = PlayerWeight;
			GetComponent<CinemachineMixingCamera> ().m_Weight0 = 1-PlayerWeight;
		}
    }
}
