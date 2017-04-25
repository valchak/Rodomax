using System.Windows.Forms;


namespace UI
{
    public partial class ModelConsulta : MetroFramework.Forms.MetroForm
    {
        public ModelConsulta()
        {
            InitializeComponent();
        }

        private void ModelConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
