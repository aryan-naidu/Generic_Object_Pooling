using UnityEngine;

public class BulletView : MonoBehaviour
{
    private int _damageValue;
    private ScreenWrapper _screenWrapper;

    private void Awake()
    {
        _screenWrapper = new ScreenWrapper();
    }

    public void SetDamageValue(int damageValue)
    {
        _damageValue = damageValue;
    }

    private void Update()
    {
        _screenWrapper.WrapAroundScreen(gameObject.transform);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            PowerUpView powerUpView = collision.gameObject.GetComponent<PowerUpView>();
            if (powerUpView != null)
            {
                powerUpView.ApplyPowerUp();
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyView enemyView = collision.gameObject.GetComponent<EnemyView>();
            if (enemyView != null)
            {
                enemyView.Damage(_damageValue);
                Destroy(gameObject);
            }
        }
    }
}
