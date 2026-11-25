using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gym_app.Member
{
    internal class MemberPresenter
    {
        private IMemberRepository _repository;
        private IMemberView _view;

        public MemberPresenter(IMemberRepository repository, IMemberView view)
        {
            _repository = repository;
            _view = view;

            //
            _view.SaveEvent += OnSave;
            _view.DisableEvent += OnDisable;
            _view.ClearEvent += (s, e) => _view.ClearInputs();
            _view.MemberSelectedEvent += (s, member) => _view.ShowMember(member);

            LoadAllMembers(); //carga inicial de datos
        }


        private void LoadAllMembers()
        {
            try
            {
                var members = _repository.GetAll();
                _view.DisplayMembers(members);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al listar sociosa: {ex.Message}", true);
            }
        }

        private void OnSave(object? sender, EventArgs e)
        {
            // validaciones
            if (string.IsNullOrWhiteSpace(_view.MemberRut) ||
                string.IsNullOrWhiteSpace(_view.MemberName) ||
                string.IsNullOrWhiteSpace(_view.MemberPhone))
            {
                _view.ShowMessage("RUT, Nombre y Telefono son obligatorios", true);
                return;
            }

            //VALIDACIONES DEL RUT Y NUMERO DE TELEFONO
            if (!MemberValidator.ValidateRut(_view.MemberRut))
            {
                _view.ShowMessage("RUT ingresado es invalido", true);
                return;
            }
            if (!MemberValidator.ValidatePhone(_view.MemberPhone))
            {
                _view.ShowMessage("Telefono ingresado es invalido", true);
                return;
            }
            if (!MemberValidator.ValidateEmail(_view.MemberEmail))
            {
                _view.ShowMessage("email ingresado invalido", true);
                return;
            }
            string Standardized_RUT = StandardizedRUT(_view.MemberRut);

            //CREACION DEL OBJETO   
            var member = new Member
            {
                MemberId = _view.MemberId,
                Rut = Standardized_RUT,
                Name = _view.MemberName,
                Phone = _view.MemberPhone,
                Email = _view.MemberEmail,
            };

            try
            {
                if (member.MemberId == 0) //si tiene el valor por defecto de un entero que es 0 y no el asignado por una db, podemos asumir que no ha sido creado
                {
                    _repository.Save(member);
                    _view.ShowMessage("Socio registrado con exito.");
                }
                else
                {
                    _repository.Update(member);
                    _view.ShowMessage("Datos del socio actualizados.");
                }
                _view.ClearInputs();
                LoadAllMembers(); // recargamos los datos para incluir el nuevo miembro.
            }
            catch(Exception ex)
            {
                _view.ShowMessage($"Error al guardar: {ex.Message}", true);
            }

        }
        private void OnDisable(object? sender, EventArgs e)
        {
            if(_view.MemberId == 0) // si la ID es 0, podemos asumir que no ha seleccionado un socio valido
            {
                _view.ShowMessage("Seleccione un socio de la tabla que desee desactivar.", true);
                return;
            }
            try
            {
                _repository.DeactivateById(_view.MemberId);
                _view.ShowMessage("Socio desactivado correctamente");
                _view.ClearInputs();
                LoadAllMembers(); // volvemos a cargar la lista
            }
            catch(Exception ex)
            {
                _view.ShowMessage($"Error al desactivar: {ex.Message}", true);
            }
        }
        private string StandardizedRUT(string rut)
        {
            string rutNormalizado = rut.Trim().Replace(".", "").Replace(" ", "").Replace("-", "");

            int indice = 0;
            for (int i = 0; i < rutNormalizado.Length; i++)
            {
                indice = i;
            }
            string body = rutNormalizado.Substring(0, indice);
            string dv = rutNormalizado.Substring(indice);
            return body + "-" + dv;

        }

    }
}
