using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LECCISAddProperty
{
  public partial class addProperty : Form
  {
    
    public addProperty()
    {
      InitializeComponent();
    }

    private void Address_Enter(object sender, EventArgs e)
    {
      Address.ForeColor = Color.Gray;
    }

    private void Address_Leave(object sender, EventArgs e)
    {
      Address.ForeColor = Color.Black;
    }

    
  }
}
