using UnityEngine;

public class SimplePlayer : MonoBehaviour // library สำหรับตอน gameplay
{
    private Rigidbody2D rigid; // ดึง component Rigidbody2D
    private Animator anim; // ดึง component Animator

    [Header("Ground And Wall Check")]
    [SerializeField] private float groundDistCheck = 1f; // ระยะไกลสุดที่ใช้ sensor ตรวจหาพื้น
    [SerializeField] private float wallDistCheck = 1f; // ระยะไกลสุดที่ใช้ sensor ตรวจหาผนัง
    [SerializeField] private LayerMask groundLayer; // layermask ของ ground และ platform
    public bool isGrounded = false; // เจอพื้น ?
    public bool isWalled = false; // เจอผนัง ?

    private void Awake() // method ที่เกิดตอนที่ gameobject นี้โดนสร้างใน game จะมาก่อน Start()
    {
        rigid = GetComponent<Rigidbody2D>(); // ดึง component จากตัวมันเอง
        anim = GetComponentInChildren<Animator>(); // ดึง component จากลูกที่เป็น sprite
    }
    private void Update() // รันทุก frame
    {
        JumpState(); // ตรวจสถานะ takeoff, landing, wallJumping, wallSliding, อื่นๆ
        Jump(); // สั่งให้กระโดด
        WallSlide(); // สั่งให้ wallSlide
        InputVal(); // เก็บ input จาก player
        Move(); // เคลื่อนที่ เน้นแนวราบ/ แกน X ตอนกระโดด
        Flip(); // หันตัวละครไปซ้าย/ขวา
        GroundAndWallCheck(); // ตรวจหาพื้นและผนัง
        Animation(); // สั่งให้ play animation
    }
    private void JumpState()
    {

    }
    private void Jump()
    {

    }
    private void WallSlide()
    {

    }
    private void InputVal()
    {

    }
    private void Move()
    {
        
    }
    private void Flip()
    {

    }
    private void GroundAndWallCheck()
    {
        //Physics2D.Raycast(จุดเริ่ม, ทิศ, ความยาว, layerที่จะหา)
        isGrounded = Physics2D.Raycast(transform.position, Vector3.down, groundDistCheck, groundLayer); // sensor ตรวจพื้น
        isWalled = Physics2D.Raycast(transform.position, transform.right, wallDistCheck, groundLayer); // sensor ตรวจผนัง
    }
    private void OnDrawGizmos() // แสดงผล UI หรือ sensor ตรวจพื้นและผนัง
    {
        // Gizmos.DrawLine(จุดเริ่ม, จุดจบ)
        Gizmos.color = Color.blue; // สีน้ำเงิน
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * groundDistCheck); // UI ของ ground
        Gizmos.color = Color.red; // สีแดง
        Gizmos.DrawLine(transform.position, transform.position + transform.right * wallDistCheck); // UI ของ wall
    }
    private void Animation()
    {

    }
}

