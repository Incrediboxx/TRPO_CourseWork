using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_Kurs_Work
{
    public partial class CreateTickets : Form
    {
        public CreateTickets(Session session)
        {
            InitializeComponent();
            label1.Text = session.GetFilm().GetName();

        }
    }
}
