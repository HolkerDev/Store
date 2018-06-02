using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferenceEdit;
using System.Windows.Forms;
using ReferemceEdit;

namespace ReferenceEdit
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        [System.ComponentModel.Bindable(true)]
        public String Reference
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.textBoxNumber.Text) == false && String.IsNullOrWhiteSpace(this.textBoxSerial.Text) == false && String.IsNullOrWhiteSpace(this.textBoxCode.Text) == false)
                {
                    return String.Format("{0}-{1}/{2}", this.textBoxNumber.Text, this.textBoxSerial.Text, this.textBoxCode.Text);
                }
                else if (String.IsNullOrWhiteSpace(this.textBoxNumber.Text) == false && String.IsNullOrWhiteSpace(this.textBoxSerial.Text) == false)
                {
                    return String.Format("{0}-{1}", this.textBoxNumber.Text, this.textBoxSerial.Text);
                }
                else if (String.IsNullOrWhiteSpace(this.textBoxNumber.Text) == false)
                {
                    return this.textBoxNumber.Text;
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) == false)
                {
                    int idx1 = value.IndexOf('-');
                    if (idx1 > 0)
                    {
                        this.textBoxNumber.Text = value.Substring(0, idx1);
                        int idx2 = value.IndexOf('-', idx1);
                        if (idx2 > 0)
                        {
                            this.textBoxSerial.Text = value.Substring(idx1, idx2 - idx1);
                            this.textBoxCode.Text = value.Substring(idx2);

                        }

                    }
                }
                else
                {
                    this.textBoxNumber.Text = "";
                    this.textBoxSerial.Text = "";
                    this.textBoxCode.Text = "";
                }
            }
        }
        public String Number
        {
            get { return this.textBoxNumber.Text; }
            set { this.textBoxNumber.Text = value; }
        }
        public String Serial
        {
            get { return this.textBoxSerial.Text; }
            set { this.textBoxSerial.Text = value; }
        }
        public String Code
        {
            get { return this.textBoxCode.Text; }
            set { this.textBoxCode.Text = value; }
        }
        public event InvalidValueHandler InvalidNumberEvent;
        public event InvalidValueHandler InvalidSerialEvent;
        public void textBoxNumber_Validating(object sender, CancelEventArgs e)
        {
            foreach (char c in textBoxNumber.Text)
            {
                if(c < '0' || c > '9')
                {
                    e.Cancel = true;
                    if (InvalidNumberEvent != null)
                    {
                        InvalidNumberEvent(this, textBoxNumber.Text);
                        break;
                    }
                }
            }

        }
        public void textBoxSerial_Validating(object sender, CancelEventArgs e)
        {
            foreach (char c in textBoxSerial.Text)
            {
                if(c < 'A' || c > 'E')
                {
                    e.Cancel = true;
                    if (InvalidSerialEvent != null)
                    {
                        InvalidSerialEvent(this, textBoxSerial.Text);
                        break;
                    }
                }
            }
        }

    }
}
