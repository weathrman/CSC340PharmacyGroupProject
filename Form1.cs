namespace CSC340PharmacyGroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowAdminPanelButton_Click(object sender, EventArgs e)
        {
            if (AdminPanel.Visible)
            {
                AdminPanel.Visible = false;
            }
            else
            {
                AdminPanel.Visible = true;
                AdminPanelShowActiveNotification.Visible = true;
                AdminPanelInactiveNotificationIcon.Visible = true;
            }
        }

        private void AdminPanelShowActiveNotification_Click(object sender, EventArgs e)
        {
            InactiveNotificationIcon.Visible = false;
            ActiveNotificationIcon.Visible = true;
        }

        private void AdminPanelInactiveNotificationIcon_Click(object sender, EventArgs e)
        {
            InactiveNotificationIcon.Visible = true;
            ActiveNotificationIcon.Visible = false;
        }

        private void ActiveNotificationIcon_Click(object sender, EventArgs e)
        {
            ShowNotificationCenter();

        }

        private void InActiveNotificationIcon_Click(object sender, EventArgs e)
        {
            ShowNotificationCenter();
        }

        private void ShowNotificationCenter()
        {
            NotificationPanel.Visible = true;
            CloseNotificationPanelButton.Visible = true;
        }

        private void CloseNotificationPanelButton_Click(object sender, EventArgs e)
        {
            NotificationPanel.Visible = false;
            CloseNotificationPanelButton.Visible = false;
        }
    }
}
