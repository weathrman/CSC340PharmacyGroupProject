namespace CSC340PharmacyGroupProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InactiveNotificationIcon = new PictureBox();
            ActiveNotificationIcon = new PictureBox();
            ShowAdminPanelButton = new Button();
            AdminPanel = new Panel();
            NotificationPanel = new Panel();
            CloseNotificationPanelButton = new Button();
            AdminPanelInactiveNotificationIcon = new Button();
            AdminPanelShowActiveNotification = new Button();
            ((System.ComponentModel.ISupportInitialize)InactiveNotificationIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ActiveNotificationIcon).BeginInit();
            AdminPanel.SuspendLayout();
            NotificationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // InactiveNotificationIcon
            // 
            InactiveNotificationIcon.BackgroundImage = (Image)resources.GetObject("InactiveNotificationIcon.BackgroundImage");
            InactiveNotificationIcon.BackgroundImageLayout = ImageLayout.Stretch;
            InactiveNotificationIcon.Cursor = Cursors.Hand;
            InactiveNotificationIcon.Location = new Point(1296, 12);
            InactiveNotificationIcon.Name = "InactiveNotificationIcon";
            InactiveNotificationIcon.Size = new Size(125, 125);
            InactiveNotificationIcon.TabIndex = 0;
            InactiveNotificationIcon.TabStop = false;
            InactiveNotificationIcon.Visible = false;
            // 
            // ActiveNotificationIcon
            // 
            ActiveNotificationIcon.BackgroundImage = (Image)resources.GetObject("ActiveNotificationIcon.BackgroundImage");
            ActiveNotificationIcon.BackgroundImageLayout = ImageLayout.Stretch;
            ActiveNotificationIcon.Cursor = Cursors.Hand;
            ActiveNotificationIcon.Location = new Point(1296, 12);
            ActiveNotificationIcon.Name = "ActiveNotificationIcon";
            ActiveNotificationIcon.Size = new Size(125, 125);
            ActiveNotificationIcon.TabIndex = 1;
            ActiveNotificationIcon.TabStop = false;
            ActiveNotificationIcon.Visible = false;
            ActiveNotificationIcon.Click += ActiveNotificationIcon_Click;
            // 
            // ShowAdminPanelButton
            // 
            ShowAdminPanelButton.BackColor = SystemColors.Control;
            ShowAdminPanelButton.ForeColor = SystemColors.ControlText;
            ShowAdminPanelButton.Location = new Point(1066, 754);
            ShowAdminPanelButton.Name = "ShowAdminPanelButton";
            ShowAdminPanelButton.Size = new Size(343, 40);
            ShowAdminPanelButton.TabIndex = 2;
            ShowAdminPanelButton.Text = "Show Admin Panel";
            ShowAdminPanelButton.UseVisualStyleBackColor = false;
            ShowAdminPanelButton.Click += ShowAdminPanelButton_Click;
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(NotificationPanel);
            AdminPanel.Controls.Add(AdminPanelInactiveNotificationIcon);
            AdminPanel.Controls.Add(AdminPanelShowActiveNotification);
            AdminPanel.Location = new Point(-5, -3);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(1065, 797);
            AdminPanel.TabIndex = 0;
            AdminPanel.Visible = false;
            // 
            // NotificationPanel
            // 
            NotificationPanel.Controls.Add(CloseNotificationPanelButton);
            NotificationPanel.Location = new Point(3, 3);
            NotificationPanel.Name = "NotificationPanel";
            NotificationPanel.Size = new Size(1423, 806);
            NotificationPanel.TabIndex = 2;
            NotificationPanel.Visible = false;
            // 
            // CloseNotificationPanelButton
            // 
            CloseNotificationPanelButton.BackColor = SystemColors.Control;
            CloseNotificationPanelButton.ForeColor = SystemColors.ControlText;
            CloseNotificationPanelButton.Location = new Point(14, 751);
            CloseNotificationPanelButton.Name = "CloseNotificationPanelButton";
            CloseNotificationPanelButton.Size = new Size(131, 40);
            CloseNotificationPanelButton.TabIndex = 3;
            CloseNotificationPanelButton.Text = "Close";
            CloseNotificationPanelButton.UseVisualStyleBackColor = false;
            CloseNotificationPanelButton.Visible = false;
            CloseNotificationPanelButton.Click += CloseNotificationPanelButton_Click;
            // 
            // AdminPanelInactiveNotificationIcon
            // 
            AdminPanelInactiveNotificationIcon.BackColor = SystemColors.Control;
            AdminPanelInactiveNotificationIcon.ForeColor = SystemColors.ControlText;
            AdminPanelInactiveNotificationIcon.Location = new Point(17, 83);
            AdminPanelInactiveNotificationIcon.Name = "AdminPanelInactiveNotificationIcon";
            AdminPanelInactiveNotificationIcon.Size = new Size(443, 40);
            AdminPanelInactiveNotificationIcon.TabIndex = 1;
            AdminPanelInactiveNotificationIcon.Text = "Show Inactive Notification";
            AdminPanelInactiveNotificationIcon.UseVisualStyleBackColor = false;
            AdminPanelInactiveNotificationIcon.Click += AdminPanelInactiveNotificationIcon_Click;
            // 
            // AdminPanelShowActiveNotification
            // 
            AdminPanelShowActiveNotification.BackColor = SystemColors.Control;
            AdminPanelShowActiveNotification.ForeColor = SystemColors.ControlText;
            AdminPanelShowActiveNotification.Location = new Point(17, 26);
            AdminPanelShowActiveNotification.Name = "AdminPanelShowActiveNotification";
            AdminPanelShowActiveNotification.Size = new Size(443, 40);
            AdminPanelShowActiveNotification.TabIndex = 0;
            AdminPanelShowActiveNotification.Text = "Show Active Notification";
            AdminPanelShowActiveNotification.UseVisualStyleBackColor = false;
            AdminPanelShowActiveNotification.Click += AdminPanelShowActiveNotification_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1421, 806);
            Controls.Add(AdminPanel);
            Controls.Add(ShowAdminPanelButton);
            Controls.Add(ActiveNotificationIcon);
            Controls.Add(InactiveNotificationIcon);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)InactiveNotificationIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ActiveNotificationIcon).EndInit();
            AdminPanel.ResumeLayout(false);
            NotificationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox InactiveNotificationIcon;
        private PictureBox ActiveNotificationIcon;
        private Button ShowAdminPanelButton;
        private Panel AdminPanel;
        private Button AdminPanelInactiveNotificationIcon;
        private Button AdminPanelShowActiveNotification;
        private Panel NotificationPanel;
        private Button CloseNotificationPanelButton;
    }
}
