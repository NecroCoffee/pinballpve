using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ピンボールのハジく所を操作するクラス
/// </summary>
public class ShooterController : MonoBehaviour
{

    [SerializeField] private GameObject shooter;//上のほうのはじくオブジェクト（今回動かすオブジェクト）
    [SerializeField] private GameObject shooterRoot;//下のほうのはじく奴の根元になるオブジェクト(動かない)

    private Vector2 shooterPos;
    private Vector2 shooterRootPos;

    private Rigidbody2D rig;

    /// <summary>
    /// shooterとshooterRootのy軸の差を出すメソッドだよ
    /// </summary>
    private Vector2 ShooterDifference()
    {
        return shooterPos;
        //エラーはいてめんどくせえから仮組み
    }

    /// <summary>
    /// 球をはじく奴を押すためのメソッドだよ
    /// </summary>
    private void PushShooter()
    {
        //rig.AddForce()
    }

    private void Awake()
    {
        //オブジェクト座標取得
        shooterPos = shooter.gameObject.transform.position;
        shooterRootPos = shooterRoot.gameObject.transform.position;

        Debug.Log("shooter.pos{" + shooterPos.x + "," + shooterPos.y + "}");
        Debug.Log("shooterRoot.pos{" + shooterRootPos.x + "," + shooterRootPos.y + "}");

        //shooterのrigidbody取得
        rig = shooter.gameObject.GetComponent<Rigidbody2D>();

    }


    private void FixedUpdate()
    {
        
    }
}
