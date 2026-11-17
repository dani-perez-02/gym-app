using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    // Que ve y que ingresa el usuario en este panel
    internal interface IMemberView
    {
        // Campos que ve el usuario + ID
        string MemberId { get; set; }
        string MemberName { get; set; }
        string MemberRut { get; set; }
        string MemberPhone {  get; set; }

        string MemberEmail { get; set; }


        // Que espera hacer el usuario
        event EventHandler Save;
        event EventHandler Disable;
        event EventHandler Clear;
        event EventHandler<Member> asdf;

        // Que debe hacer la pantalla
        void DisplayMembers(IEnumerable<Member> members);
        void ShowMember(Member member);
        void ShowMessage(string msg, bool isError);
    }
}
