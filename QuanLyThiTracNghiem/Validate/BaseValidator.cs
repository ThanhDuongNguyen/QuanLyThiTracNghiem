using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThiTracNghiem.Validate
{
    public abstract partial class BaseValidator : Component
    {
        public BaseValidator()
        {
            InitializeComponent();
        }

        public BaseValidator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        ErrorProvider errorProvider = new ErrorProvider();

        public string ErrorMessage { get; set; }
        public Icon ErrorIcon { get => errorProvider.Icon; set => errorProvider.Icon = value; }

        Control control2Validate;

        [TypeConverter(typeof(ReferenceConverter))]
        public Control ControlToValidate
        {
            get => control2Validate;
            set
            {
                control2Validate = value;
                if (control2Validate != null && !DesignMode)
                {
                    control2Validate.Validating += Control2Validate_Validating;
                }
            }
        }

        private void Control2Validate_Validating(object sender, CancelEventArgs e)
        {

            if (!Validate())
            {
                e.Cancel = true;
                errorProvider.SetError(control2Validate, ErrorMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(control2Validate, "");
            }
        }

        public abstract bool Validate();
    }
}
