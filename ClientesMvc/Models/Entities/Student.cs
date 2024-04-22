namespace ClientesMvc.Models.Entities
{
    public class Student
    {
        // Guid -> inteiro de 128 bits
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool Subscribed { get; set; }
    }
}
