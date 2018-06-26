using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int value = 3;
        int flag = 1;
        while (true)
        {
            float sum = 0;
            if (flag == 1)
            {
                this.transform.Translate(flag * 2 * Time.deltaTime, 0, 0);
                sum += flag * 2 * Time.deltaTime;
                if (sum == value)
                    flag = -1;
            }

            if (flag == -1)
            {
                this.transform.Translate(flag * 2 * Time.deltaTime, 0, 0);
                sum -= flag * 2 * Time.deltaTime;
                if (sum == value)
                    flag = 1;
            }
        }
	}
}
