using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WhereIStand.Model;

namespace WhereIStand.View.Controls
{
    /// <summary>
    /// Interaction logic for AssignmentControl.xaml
    /// </summary>
    public partial class AssignmentControl : UserControl
    {
        public AssignmentControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty AssignmentProperty =
            DependencyProperty.Register("Assignment", typeof(assignment), typeof(AssignmentControl));

        public assignment Assignment
        {
            get { return (assignment)GetValue(AssignmentProperty); }
            set { SetValue(AssignmentProperty, value); }
        }

    }
}
