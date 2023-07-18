using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTest : MonoBehaviour
{
    //lineRenderer�p
    [SerializeField]
    private LineRenderer lineRenderer;
    [SerializeField]
    private float widthStart = 0.1f;
    [SerializeField]
    private float widthEnd = 0.1f;


    //�������Z�p
    private Rigidbody2D rig;
    private Vector2 rigPos;
    //�������Z�����p
    [SerializeField]
    private float rigAddForceRandx;
    [SerializeField]
    private float rigAddForceRandy;
    [SerializeField]
    private float rigAddForceRandMin = 1f;
    [SerializeField]
    private float rigAddForceRandMax = 10f;


    private void SetPosition(Vector2 pos)
    {
        
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, pos);
    }

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�擾
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        rig = gameObject.GetComponent<Rigidbody2D>();
        //��������
        rigAddForceRandx = Random.Range(rigAddForceRandMin, rigAddForceRandMax);
        rigAddForceRandy = Random.Range(rigAddForceRandMin, rigAddForceRandMax);
        //rig�ɗ͂������ď����̈ړ����������߂�
        rig.AddForce(new Vector2(rigAddForceRandx, rigAddForceRandy)*2);
    }

    // Update is called once per frame
    void Update()
    {
        rigPos = this.transform.position;
        SetPosition(rigPos);
    }
}
