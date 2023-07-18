using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTest : MonoBehaviour
{
    //lineRenderer用
    [SerializeField]
    private LineRenderer lineRenderer;
    [SerializeField]
    private float widthStart = 0.1f;
    [SerializeField]
    private float widthEnd = 0.1f;


    //物理演算用
    private Rigidbody2D rig;
    private Vector2 rigPos;
    //物理演算乱数用
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
        //コンポーネント取得
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        rig = gameObject.GetComponent<Rigidbody2D>();
        //乱数生成
        rigAddForceRandx = Random.Range(rigAddForceRandMin, rigAddForceRandMax);
        rigAddForceRandy = Random.Range(rigAddForceRandMin, rigAddForceRandMax);
        //rigに力を加えて初期の移動方向を決める
        rig.AddForce(new Vector2(rigAddForceRandx, rigAddForceRandy)*2);
    }

    // Update is called once per frame
    void Update()
    {
        rigPos = this.transform.position;
        SetPosition(rigPos);
    }
}
