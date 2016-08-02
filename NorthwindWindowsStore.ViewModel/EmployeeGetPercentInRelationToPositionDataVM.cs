
namespace NorthwindWindowsStore.ViewModel
{
    public class EmployeeGetPercentInRelationToPositionDataVM : BaseVM<EmployeeGetPercentInRelationToPositionViewModel>
    {
        public EmployeeGetPercentInRelationToPositionDataVM()
        {
        }

        public EmployeeGetPercentInRelationToPositionDataVM(EmployeeGetPercentInRelationToPositionViewModel model)
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
