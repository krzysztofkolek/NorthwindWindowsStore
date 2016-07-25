using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace NorthwindWindowsStore.Utils
{
    public abstract class BasePage<I,O> : Page
        where I: class, new()
        where O: class, new()
    {
        List<O> temp = NorthwindWindowsStore.Utils.ContentManager.GetContent<I, O>("Employees/GetAll").Result;
    }
}
