using UnityEngine;

public class ExplosiveEnemy : MonoBehaviour, IActor {
    public int Hp { get; set; }
    public int MaxHp { get; }
    public int Damage { get; }
    public Transform GameObjectTransform { get; }
    public GameObject HealthBar { get; set; }
    [SerializeField] private GameObject collectible;
    private static int _dropRate;
    
    public void TakeDamage(int damage) {
        throw new System.NotImplementedException();
    }

    public void Attack() {
        throw new System.NotImplementedException();
    }

    public void Die() {
        throw new System.NotImplementedException();
    }

    public void Move() {
        throw new System.NotImplementedException();
    }
    

   
}