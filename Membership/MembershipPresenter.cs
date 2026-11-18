namespace gym_app.Membership
{
    internal class MembershipPresenter
    {
        private readonly MembershipService _service;
        private readonly IMembershipView _view;
        private List<Plan.Plan> _plans = new();

        public MembershipPresenter(MembershipService service, IMembershipView view)
        {
            _service = service;
            _view = view;

            _view.SaveEvent += OnSave;
            _view.CancelMembershipEvent += OnCancelMembership;
            _view.ClearEvent += (s, e) =>
            {
                _view.ClearInputs();
                UpdateEndDatePreview();
            };
            _view.PlanOrDateChangedEvent += (s, e) => UpdateEndDatePreview();
            _view.MembershipSelectedEvent += (s, membership) => _view.ShowMembership(membership);

            LoadInitialData();
        }

        private void LoadInitialData()
        {
            try
            {
                _plans = _service.GetActivePlans().ToList();
                _view.LoadMembers(_service.GetActiveMembers());
                _view.LoadPlans(_plans);
                _view.DisplayMemberships(_service.GetAllMemberships());
                UpdateEndDatePreview();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al cargar datos: {ex.Message}", true);
            }
        }

        private void UpdateEndDatePreview()
        {
            var plan = _plans.FirstOrDefault(p => p.PlanId == _view.SelectedPlanId);
            if (plan == null)
            {
                _view.EndDatePreview = "-";
                return;
            }

            var endDate = _service.CalculateEndDate(_view.StartDate, plan.DurationInDays);
            _view.EndDatePreview = endDate.ToString("dd/MM/yyyy");
        }

        private void OnSave(object? sender, EventArgs e)
        {
            try
            {
                _service.RegisterMembership(
                    _view.SelectedMemberId,
                    _view.SelectedPlanId,
                    _view.StartDate
                );

                _view.ShowMessage("Suscripción registrada con éxito.");
                _view.ClearInputs();
                UpdateEndDatePreview();
                _view.DisplayMemberships(_service.GetAllMemberships());
            }
            catch (InvalidOperationException ex)
            {
                _view.ShowMessage(ex.Message, true);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al registrar suscripción: {ex.Message}", true);
            }
        }

        private void OnCancelMembership(object? sender, EventArgs e)
        {
            try
            {
                _service.CancelMembership(_view.MembershipId);
                _view.ShowMessage("Suscripción cancelada correctamente.");
                _view.ClearInputs();
                UpdateEndDatePreview();
                _view.DisplayMemberships(_service.GetAllMemberships());
            }
            catch (InvalidOperationException ex)
            {
                _view.ShowMessage(ex.Message, true);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Error al cancelar suscripción: {ex.Message}", true);
            }
        }
    }
}