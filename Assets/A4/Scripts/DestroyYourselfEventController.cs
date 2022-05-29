using UnityEngine;

namespace A4.Scripts
{
    public class DestroyYourselfEventController : MonoBehaviour
    {
        public void DestroyYourself()
        {
            Destroy(this.gameObject);
        }
    }
}