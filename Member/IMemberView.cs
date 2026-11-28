using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// que hace el usuario en esta pantalla?
namespace gym_app.Member
{
    internal interface IMemberView
    {
        // propiedades -> Que datos necesita leer o escribir?
        int MemberId { get; set; }
        string MemberName { get; set; }
        string MemberRut { get; set; }
        string MemberPhone { get; set; }
        string MemberEmail { get; set; }
        MemberFilter.MembersFilter SelectFilter { get;}


        // eventos -> que "hace" el usuario en esta pantalla?
        event EventHandler SaveEvent;
        event EventHandler DisableEvent;
        event EventHandler ClearEvent;
        event EventHandler<Member> MemberSelectedEvent;
        event EventHandler FilterChangeEvent;

        // metodos -> que le pido a la pantalla que haga o muestre?
        void DisplayMembers(IEnumerable<Member> members);
        void ShowMember(Member member);
        void ShowMessage(string msg, bool isError = false);
        void ClearInputs();
    }
}
