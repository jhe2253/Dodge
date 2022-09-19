 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f; // ź�� �̵��ӵ�
    private Rigidbody BulletRigidbody; // �̵��� ����� ������ٵ� ������Ʈ

    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        BulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�
        BulletRigidbody.velocity = transform.forward * speed;

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �İ�
        Destroy(gameObject, 3f);
    }

    // Ʈ���� �⵹ �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���ӿ�����Ʈ�� Player �±׸� ���� ���
        if (other.tag == "Player")
        {
            //���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            // �������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            if(playerController != null)
            {
                // ���� PlayerController ������Ʈ�� Die() �޼��� ����
                playerController.Die();
            }
        }
    }
}
