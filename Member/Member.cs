using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    internal class Member
    {
        private int MemberId { get; set; }
        private string Name { get; set; }

        private string Rut {  get; set; }

        private string Email {  get; set; }
        private string Phone {  get; set; }
        private bool IsActive { get; set; }
        private DateTime RegisteredAt { get; set; }
    }
}
