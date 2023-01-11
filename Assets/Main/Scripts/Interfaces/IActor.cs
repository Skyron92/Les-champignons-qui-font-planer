using UnityEngine;
using UnityEngine.Serialization;

public interface IActor {
    public int Hp { get; set; }
    public int MaxHp { get; }
    public int Damage { get; }
    public Transform GameObjectTransform { get; }
    public GameObject HealthBar { get; set; }
    
    public void TakeDamage(int damage);
    public void Attack();
    public void Die();
    public void Move();
}