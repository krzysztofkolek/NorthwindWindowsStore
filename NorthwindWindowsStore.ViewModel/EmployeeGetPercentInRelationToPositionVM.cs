namespace NorthwindWindowsStore.ViewModel
{

    public class EmployeeGetPercentInRelationToPositionVM : BaseVM<EmployeeGetPercentInRelationToPositionViewModel>
    {
        public EmployeeGetPercentInRelationToPositionVM()
        {
        }

        public EmployeeGetPercentInRelationToPositionVM(EmployeeGetPercentInRelationToPositionViewModel model)
        {
            Member.Title = model.Title;
            Member.Amount = model.Amount;
        }

        public string Label
        {
            get
            {
                return Member.Title;
            }
        }

        public double Value
        {
            get
            {
                return Member.Amount;
            }
        }
    }
}
