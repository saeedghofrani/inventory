using System;
using System.Linq;
using System.Windows.Forms;




namespace inventory_project
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            var login_frm = new Form1();
            var res = login_frm.ShowDialog();
            if (res == DialogResult.Abort)
                Close();
           // customizeDesign();

        }

        private void customizeDesign()
        {
            //panelTransaction.Visible = false;
            //panelProduct.Visible = false;
            //panelExtra.Visible = false;
        }
        private void hideSubMenu()
        {
            //if (panelTransaction.Visible == true)
             //   panelTransaction.Visible = false;
           // if (panelProduct.Visible == true)
             //   panelProduct.Visible = false;
            //if (panelExtra.Visible == true)
              //  panelExtra.Visible = false;
        }
        private void showPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else panel.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
           // showPanel(panelTransaction);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildform(new Form2());
            hideSubMenu();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildform(new Form2());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            //showPanel(panelProduct);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void buttonLowStock_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            //showPanel(panelExtra);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //...
            hideSubMenu();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        private Form activeform = null;
        private void openChildform(Form Childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = Childform;
            Childform.TopLevel = false;
            Childform.FormBorderStyle = FormBorderStyle.None;
            Childform.Dock = DockStyle.Fill;
            panelChildform.Tag = Childform;
            panelChildform.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();

        }

        private void panelChildform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Visible == true)
                panelSideMenu.Visible = false;
            else
            {
                panelSideMenu.Visible = true;
            }
        }

        private void panelInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelExtra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTransaction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
