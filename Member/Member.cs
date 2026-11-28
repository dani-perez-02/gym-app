using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    internal class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Rut {  get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public bool IsActive { get; set; }
        public DateTime RegisteredAt { get; set; }
     
    }
}
