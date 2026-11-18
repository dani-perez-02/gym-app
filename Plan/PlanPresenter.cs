namespace gym_app.Plan
{
    internal class PlanPresenter
    {
        private readonly IPlanRepository _repository;
        private readonly IPlanView _view;

        public PlanPresenter(IPlanRepository repository, IPlanView view)
        {
            _repository = repository;
            _view = view;

            _view.SaveEvent += OnSave;
            _view.DisableEvent += OnDisable;
            _view.ClearEvent += (s, e) => _view.ClearInputs();
            _view.PlanSelectedEvent += (s, plan) => _view.ShowPlan(plan);

            LoadAllPlans();
        }

        private void LoadAllPlans()
        {
            try
            {
                var plans = _repository.GetAll();
                _view.DisplayPlans(plans);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al listar planes: {ex.Message}", true);
            }
        }

        private void OnSave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.PlanName))
            {
                _view.ShowMessage("El nombre del plan es obligatorio.", true);
                return;
            }

            if (!int.TryParse(_view.PlanDuration, out int duration) || duration <= 0)
            {
                _view.ShowMessage("La duración debe ser un número entero mayor a 0.", true);
                return;
            }

            if (!int.TryParse(_view.PlanPrice, out int price) || price < 0)
            {
                _view.ShowMessage("El precio debe ser un número entero válido (0 o mayor).", true);
                return;
            }

            var plan = new Plan
            {
                PlanId = _view.PlanId,
                Name = _view.PlanName.Trim(),
                DurationInDays = duration,
                Price = price
            };

            try
            {
                if (plan.PlanId == 0)
                {
                    _repository.Save(plan);
                    _view.ShowMessage("Plan registrado con éxito.");
                }
                else
                {
                    _repository.Update(plan);
                    _view.ShowMessage("Datos del plan actualizados.");
                }

                _view.ClearInputs();
                LoadAllPlans();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al guardar: {ex.Message}", true);
            }
        }

        private void OnDisable(object? sender, EventArgs e)
        {
            if (_view.PlanId == 0)
            {
                _view.ShowMessage("Seleccione un plan de la tabla que desee desactivar.", true);
                return;
            }

            try
            {
                _repository.DeactivateById(_view.PlanId);
                _view.ShowMessage("Plan desactivado correctamente.");
                _view.ClearInputs();
                LoadAllPlans();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al desactivar: {ex.Message}", true);
            }
        }
    }
}