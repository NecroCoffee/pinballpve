using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �s���{�[���̃n�W�����𑀍삷��N���X
/// </summary>
public class ShooterController : MonoBehaviour
{

    [SerializeField] private GameObject shooter;//��̂ق��̂͂����I�u�W�F�N�g�i���񓮂����I�u�W�F�N�g�j
    [SerializeField] private GameObject shooterRoot;//���̂ق��̂͂����z�̍����ɂȂ�I�u�W�F�N�g(�����Ȃ�)

    private Vector2 shooterPos;
    private Vector2 shooterRootPos;

    private Rigidbody2D rig;

    /// <summary>
    /// shooter��shooterRoot��y���̍����o�����\�b�h����
    /// </summary>
    private Vector2 ShooterDifference()
    {
        return shooterPos;
        //�G���[�͂��Ă߂�ǂ��������牼�g��
    }

    /// <summary>
    /// �����͂����z���������߂̃��\�b�h����
    /// </summary>
    private void PushShooter()
    {
        //rig.AddForce()
    }

    private void Awake()
    {
        //�I�u�W�F�N�g���W�擾
        shooterPos = shooter.gameObject.transform.position;
        shooterRootPos = shooterRoot.gameObject.transform.position;

        Debug.Log("shooter.pos{" + shooterPos.x + "," + shooterPos.y + "}");
        Debug.Log("shooterRoot.pos{" + shooterRootPos.x + "," + shooterRootPos.y + "}");

        //shooter��rigidbody�擾
        rig = shooter.gameObject.GetComponent<Rigidbody2D>();

    }


    private void FixedUpdate()
    {
        
    }
}
