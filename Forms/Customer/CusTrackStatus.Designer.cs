namespace Eshift.Forms.Customer
{
    partial class CusTrackStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainContainer = new Panel();
            trackingContentPanel = new Panel();
            trackingCard = new Panel();
            progressTrackingPanel = new Panel();
            statusLorryPanel = new Panel();
            lorryIcon = new Label();
            currentLocationLabel = new Label();
            estimatedArrivalLabel = new Label();
            progressLinePanel = new Panel();
            progressLine = new Panel();
            progressFill = new Panel();
            stepsContainer = new Panel();
            step4Panel = new Panel();
            step4Circle = new Panel();
            step4Check = new Label();
            step4Label = new Label();
            step4Icon = new Label();
            step3Panel = new Panel();
            step3Circle = new Panel();
            step3Check = new Label();
            step3Label = new Label();
            step3Icon = new Label();
            step2Panel = new Panel();
            step2Circle = new Panel();
            step2Check = new Label();
            step2Label = new Label();
            step2Icon = new Label();
            step1Panel = new Panel();
            step1Circle = new Panel();
            step1Check = new Label();
            step1Label = new Label();
            step1Icon = new Label();
            jobDetailsPanel = new Panel();
            deliveryInfoPanel = new Panel();
            destinationLabel = new Label();
            destinationValueLabel = new Label();
            startLocationLabel = new Label();
            startLocationValueLabel = new Label();
            trackingNumberPanel = new Panel();
            trackingNumberLabel = new Label();
            trackingNumberValueLabel = new Label();
            expectedArrivalPanel = new Panel();
            expectedArrivalLabel = new Label();
            expectedArrivalValueLabel = new Label();
            noJobSelectedPanel = new Panel();
            noJobSelectedLabel = new Label();
            selectJobPromptLabel = new Label();
            jobSelectionPanel = new Panel();
            jobSelectionHeaderPanel = new Panel();
            jobSelectionLabel = new Label();
            jobSelectionIcon = new Label();
            cbJobs = new ComboBox();
            selectJobLabel = new Label();
            refreshButton = new Button();
            headerPanel = new Panel();
            headerLabel = new Label();
            mainContainer.SuspendLayout();
            trackingContentPanel.SuspendLayout();
            trackingCard.SuspendLayout();
            progressTrackingPanel.SuspendLayout();
            statusLorryPanel.SuspendLayout();
            progressLinePanel.SuspendLayout();
            progressLine.SuspendLayout();
            stepsContainer.SuspendLayout();
            step4Panel.SuspendLayout();
            step4Circle.SuspendLayout();
            step3Panel.SuspendLayout();
            step3Circle.SuspendLayout();
            step2Panel.SuspendLayout();
            step2Circle.SuspendLayout();
            step1Panel.SuspendLayout();
            step1Circle.SuspendLayout();
            jobDetailsPanel.SuspendLayout();
            deliveryInfoPanel.SuspendLayout();
            trackingNumberPanel.SuspendLayout();
            expectedArrivalPanel.SuspendLayout();
            noJobSelectedPanel.SuspendLayout();
            jobSelectionPanel.SuspendLayout();
            jobSelectionHeaderPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.BackColor = Color.FromArgb(240, 244, 248);
            mainContainer.Controls.Add(trackingContentPanel);
            mainContainer.Controls.Add(jobSelectionPanel);
            mainContainer.Controls.Add(headerPanel);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1099, 729);
            mainContainer.TabIndex = 0;
            // 
            // trackingContentPanel
            // 
            trackingContentPanel.BackColor = Color.Transparent;
            trackingContentPanel.Controls.Add(trackingCard);
            trackingContentPanel.Controls.Add(noJobSelectedPanel);
            trackingContentPanel.Dock = DockStyle.Fill;
            trackingContentPanel.Location = new Point(0, 160);
            trackingContentPanel.Name = "trackingContentPanel";
            trackingContentPanel.Padding = new Padding(30);
            trackingContentPanel.Size = new Size(1099, 569);
            trackingContentPanel.TabIndex = 2;
            // 
            // trackingCard
            // 
            trackingCard.BackColor = Color.White;
            trackingCard.Controls.Add(progressTrackingPanel);
            trackingCard.Controls.Add(jobDetailsPanel);
            trackingCard.Dock = DockStyle.Fill;
            trackingCard.Location = new Point(30, 30);
            trackingCard.Name = "trackingCard";
            trackingCard.Size = new Size(1039, 509);
            trackingCard.TabIndex = 0;
            trackingCard.Visible = false;
            // 
            // progressTrackingPanel
            // 
            progressTrackingPanel.BackColor = Color.FromArgb(248, 249, 250);
            progressTrackingPanel.Controls.Add(statusLorryPanel);
            progressTrackingPanel.Controls.Add(progressLinePanel);
            progressTrackingPanel.Controls.Add(stepsContainer);
            progressTrackingPanel.Dock = DockStyle.Fill;
            progressTrackingPanel.Location = new Point(0, 120);
            progressTrackingPanel.Name = "progressTrackingPanel";
            progressTrackingPanel.Padding = new Padding(40);
            progressTrackingPanel.Size = new Size(1039, 389);
            progressTrackingPanel.TabIndex = 1;
            // 
            // statusLorryPanel
            // 
            statusLorryPanel.BackColor = Color.Transparent;
            statusLorryPanel.Controls.Add(lorryIcon);
            statusLorryPanel.Controls.Add(currentLocationLabel);
            statusLorryPanel.Controls.Add(estimatedArrivalLabel);
            statusLorryPanel.Location = new Point(100, 250);
            statusLorryPanel.Name = "statusLorryPanel";
            statusLorryPanel.Size = new Size(839, 136);
            statusLorryPanel.TabIndex = 2;
            // 
            // lorryIcon
            // 
            lorryIcon.AutoSize = true;
            lorryIcon.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            lorryIcon.ForeColor = Color.FromArgb(46, 125, 50);
            lorryIcon.Location = new Point(350, 20);
            lorryIcon.Name = "lorryIcon";
            lorryIcon.Size = new Size(125, 86);
            lorryIcon.TabIndex = 0;
            lorryIcon.Text = "🚛";
            lorryIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentLocationLabel
            // 
            currentLocationLabel.AutoSize = true;
            currentLocationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            currentLocationLabel.ForeColor = Color.FromArgb(64, 64, 64);
            currentLocationLabel.Location = new Point(280, 0);
            currentLocationLabel.Name = "currentLocationLabel";
            currentLocationLabel.Size = new Size(282, 21);
            currentLocationLabel.TabIndex = 1;
            currentLocationLabel.Text = "Your shipment is currently in transit";
            currentLocationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // estimatedArrivalLabel
            // 
            estimatedArrivalLabel.AutoSize = true;
            estimatedArrivalLabel.Font = new Font("Segoe UI", 10F);
            estimatedArrivalLabel.ForeColor = Color.FromArgb(100, 100, 100);
            estimatedArrivalLabel.Location = new Point(320, 106);
            estimatedArrivalLabel.Name = "estimatedArrivalLabel";
            estimatedArrivalLabel.Size = new Size(212, 19);
            estimatedArrivalLabel.TabIndex = 2;
            estimatedArrivalLabel.Text = "Estimated arrival: Tomorrow 2PM";
            estimatedArrivalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressLinePanel
            // 
            progressLinePanel.BackColor = Color.Transparent;
            progressLinePanel.Controls.Add(progressLine);
            progressLinePanel.Location = new Point(60, 35);
            progressLinePanel.Name = "progressLinePanel";
            progressLinePanel.Size = new Size(680, 8);
            progressLinePanel.TabIndex = 1;
            // 
            // progressLine
            // 
            progressLine.BackColor = Color.FromArgb(230, 230, 230);
            progressLine.Controls.Add(progressFill);
            progressLine.Dock = DockStyle.Fill;
            progressLine.Location = new Point(0, 0);
            progressLine.Name = "progressLine";
            progressLine.Size = new Size(680, 8);
            progressLine.TabIndex = 0;
            // 
            // progressFill
            // 
            progressFill.BackColor = Color.FromArgb(46, 125, 50);
            progressFill.Dock = DockStyle.Left;
            progressFill.Location = new Point(0, 0);
            progressFill.Name = "progressFill";
            progressFill.Size = new Size(419, 8);
            progressFill.TabIndex = 0;
            // 
            // stepsContainer
            // 
            stepsContainer.BackColor = Color.Transparent;
            stepsContainer.Controls.Add(step4Panel);
            stepsContainer.Controls.Add(step3Panel);
            stepsContainer.Controls.Add(step2Panel);
            stepsContainer.Controls.Add(step1Panel);
            stepsContainer.Location = new Point(40, 40);
            stepsContainer.Name = "stepsContainer";
            stepsContainer.Size = new Size(959, 120);
            stepsContainer.TabIndex = 0;
            // 
            // step4Panel
            // 
            step4Panel.BackColor = Color.Transparent;
            step4Panel.Controls.Add(step4Circle);
            step4Panel.Controls.Add(step4Label);
            step4Panel.Controls.Add(step4Icon);
            step4Panel.Location = new Point(720, 0);
            step4Panel.Name = "step4Panel";
            step4Panel.Size = new Size(120, 120);
            step4Panel.TabIndex = 3;
            // 
            // step4Circle
            // 
            step4Circle.BackColor = Color.FromArgb(230, 230, 230);
            step4Circle.Controls.Add(step4Check);
            step4Circle.Location = new Point(85, 20);
            step4Circle.Name = "step4Circle";
            step4Circle.Size = new Size(30, 30);
            step4Circle.TabIndex = 0;
            // 
            // step4Check
            // 
            step4Check.AutoSize = true;
            step4Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            step4Check.ForeColor = Color.White;
            step4Check.Location = new Point(8, 3);
            step4Check.Name = "step4Check";
            step4Check.Size = new Size(23, 21);
            step4Check.TabIndex = 0;
            step4Check.Text = "✓";
            step4Check.TextAlign = ContentAlignment.MiddleCenter;
            step4Check.Visible = false;
            // 
            // step4Label
            // 
            step4Label.AutoSize = true;
            step4Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            step4Label.ForeColor = Color.FromArgb(100, 100, 100);
            step4Label.Location = new Point(25, 80);
            step4Label.Name = "step4Label";
            step4Label.Size = new Size(83, 19);
            step4Label.TabIndex = 2;
            step4Label.Text = "Completed";
            step4Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step4Icon
            // 
            step4Icon.AutoSize = true;
            step4Icon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            step4Icon.ForeColor = Color.FromArgb(100, 100, 100);
            step4Icon.Location = new Point(25, 5);
            step4Icon.Name = "step4Icon";
            step4Icon.Size = new Size(85, 59);
            step4Icon.TabIndex = 1;
            step4Icon.Text = "✅";
            step4Icon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step3Panel
            // 
            step3Panel.BackColor = Color.Transparent;
            step3Panel.Controls.Add(step3Circle);
            step3Panel.Controls.Add(step3Label);
            step3Panel.Controls.Add(step3Icon);
            step3Panel.Location = new Point(480, 0);
            step3Panel.Name = "step3Panel";
            step3Panel.Size = new Size(120, 120);
            step3Panel.TabIndex = 2;
            // 
            // step3Circle
            // 
            step3Circle.BackColor = Color.FromArgb(46, 125, 50);
            step3Circle.Controls.Add(step3Check);
            step3Circle.Location = new Point(85, 20);
            step3Circle.Name = "step3Circle";
            step3Circle.Size = new Size(30, 30);
            step3Circle.TabIndex = 0;
            // 
            // step3Check
            // 
            step3Check.AutoSize = true;
            step3Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            step3Check.ForeColor = Color.White;
            step3Check.Location = new Point(8, 3);
            step3Check.Name = "step3Check";
            step3Check.Size = new Size(23, 21);
            step3Check.TabIndex = 0;
            step3Check.Text = "✓";
            step3Check.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step3Label
            // 
            step3Label.AutoSize = true;
            step3Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            step3Label.ForeColor = Color.FromArgb(46, 125, 50);
            step3Label.Location = new Point(30, 80);
            step3Label.Name = "step3Label";
            step3Label.Size = new Size(81, 19);
            step3Label.TabIndex = 2;
            step3Label.Text = "Processing";
            step3Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step3Icon
            // 
            step3Icon.AutoSize = true;
            step3Icon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            step3Icon.ForeColor = Color.FromArgb(46, 125, 50);
            step3Icon.Location = new Point(25, 5);
            step3Icon.Name = "step3Icon";
            step3Icon.Size = new Size(85, 59);
            step3Icon.TabIndex = 1;
            step3Icon.Text = "⚙️";
            step3Icon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step2Panel
            // 
            step2Panel.BackColor = Color.Transparent;
            step2Panel.Controls.Add(step2Circle);
            step2Panel.Controls.Add(step2Label);
            step2Panel.Controls.Add(step2Icon);
            step2Panel.Location = new Point(240, 0);
            step2Panel.Name = "step2Panel";
            step2Panel.Size = new Size(120, 120);
            step2Panel.TabIndex = 1;
            // 
            // step2Circle
            // 
            step2Circle.BackColor = Color.FromArgb(46, 125, 50);
            step2Circle.Controls.Add(step2Check);
            step2Circle.Location = new Point(85, 20);
            step2Circle.Name = "step2Circle";
            step2Circle.Size = new Size(30, 30);
            step2Circle.TabIndex = 0;
            // 
            // step2Check
            // 
            step2Check.AutoSize = true;
            step2Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            step2Check.ForeColor = Color.White;
            step2Check.Location = new Point(8, 3);
            step2Check.Name = "step2Check";
            step2Check.Size = new Size(23, 21);
            step2Check.TabIndex = 0;
            step2Check.Text = "✓";
            step2Check.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step2Label
            // 
            step2Label.AutoSize = true;
            step2Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            step2Label.ForeColor = Color.FromArgb(46, 125, 50);
            step2Label.Location = new Point(35, 80);
            step2Label.Name = "step2Label";
            step2Label.Size = new Size(77, 19);
            step2Label.TabIndex = 2;
            step2Label.Text = "Approved";
            step2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step2Icon
            // 
            step2Icon.AutoSize = true;
            step2Icon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            step2Icon.ForeColor = Color.FromArgb(46, 125, 50);
            step2Icon.Location = new Point(25, 5);
            step2Icon.Name = "step2Icon";
            step2Icon.Size = new Size(85, 59);
            step2Icon.TabIndex = 1;
            step2Icon.Text = "📦";
            step2Icon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step1Panel
            // 
            step1Panel.BackColor = Color.Transparent;
            step1Panel.Controls.Add(step1Circle);
            step1Panel.Controls.Add(step1Label);
            step1Panel.Controls.Add(step1Icon);
            step1Panel.Location = new Point(0, 0);
            step1Panel.Name = "step1Panel";
            step1Panel.Size = new Size(120, 120);
            step1Panel.TabIndex = 0;
            // 
            // step1Circle
            // 
            step1Circle.BackColor = Color.FromArgb(46, 125, 50);
            step1Circle.Controls.Add(step1Check);
            step1Circle.Location = new Point(85, 20);
            step1Circle.Name = "step1Circle";
            step1Circle.Size = new Size(30, 30);
            step1Circle.TabIndex = 0;
            // 
            // step1Check
            // 
            step1Check.AutoSize = true;
            step1Check.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            step1Check.ForeColor = Color.White;
            step1Check.Location = new Point(8, 3);
            step1Check.Name = "step1Check";
            step1Check.Size = new Size(23, 21);
            step1Check.TabIndex = 0;
            step1Check.Text = "✓";
            step1Check.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step1Label
            // 
            step1Label.AutoSize = true;
            step1Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            step1Label.ForeColor = Color.FromArgb(46, 125, 50);
            step1Label.Location = new Point(25, 80);
            step1Label.Name = "step1Label";
            step1Label.Size = new Size(70, 19);
            step1Label.TabIndex = 2;
            step1Label.Text = "Received";
            step1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // step1Icon
            // 
            step1Icon.AutoSize = true;
            step1Icon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            step1Icon.ForeColor = Color.FromArgb(46, 125, 50);
            step1Icon.Location = new Point(25, 5);
            step1Icon.Name = "step1Icon";
            step1Icon.Size = new Size(85, 59);
            step1Icon.TabIndex = 1;
            step1Icon.Text = "📋";
            step1Icon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jobDetailsPanel
            // 
            jobDetailsPanel.BackColor = Color.White;
            jobDetailsPanel.Controls.Add(deliveryInfoPanel);
            jobDetailsPanel.Controls.Add(trackingNumberPanel);
            jobDetailsPanel.Controls.Add(expectedArrivalPanel);
            jobDetailsPanel.Dock = DockStyle.Top;
            jobDetailsPanel.Location = new Point(0, 0);
            jobDetailsPanel.Name = "jobDetailsPanel";
            jobDetailsPanel.Size = new Size(1039, 120);
            jobDetailsPanel.TabIndex = 0;
            // 
            // deliveryInfoPanel
            // 
            deliveryInfoPanel.BackColor = Color.Transparent;
            deliveryInfoPanel.Controls.Add(destinationLabel);
            deliveryInfoPanel.Controls.Add(destinationValueLabel);
            deliveryInfoPanel.Controls.Add(startLocationLabel);
            deliveryInfoPanel.Controls.Add(startLocationValueLabel);
            deliveryInfoPanel.Location = new Point(400, 20);
            deliveryInfoPanel.Name = "deliveryInfoPanel";
            deliveryInfoPanel.Size = new Size(300, 80);
            deliveryInfoPanel.TabIndex = 2;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            destinationLabel.ForeColor = Color.FromArgb(64, 64, 64);
            destinationLabel.Location = new Point(0, 50);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(88, 19);
            destinationLabel.TabIndex = 2;
            destinationLabel.Text = "Destination:";
            // 
            // destinationValueLabel
            // 
            destinationValueLabel.AutoSize = true;
            destinationValueLabel.Font = new Font("Segoe UI", 10F);
            destinationValueLabel.ForeColor = Color.FromArgb(100, 100, 100);
            destinationValueLabel.Location = new Point(100, 50);
            destinationValueLabel.Name = "destinationValueLabel";
            destinationValueLabel.Size = new Size(149, 19);
            destinationValueLabel.TabIndex = 3;
            destinationValueLabel.Text = "123 Main St, New York";
            // 
            // startLocationLabel
            // 
            startLocationLabel.AutoSize = true;
            startLocationLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            startLocationLabel.ForeColor = Color.FromArgb(64, 64, 64);
            startLocationLabel.Location = new Point(0, 20);
            startLocationLabel.Name = "startLocationLabel";
            startLocationLabel.Size = new Size(48, 19);
            startLocationLabel.TabIndex = 0;
            startLocationLabel.Text = "From:";
            // 
            // startLocationValueLabel
            // 
            startLocationValueLabel.AutoSize = true;
            startLocationValueLabel.Font = new Font("Segoe UI", 10F);
            startLocationValueLabel.ForeColor = Color.FromArgb(100, 100, 100);
            startLocationValueLabel.Location = new Point(100, 20);
            startLocationValueLabel.Name = "startLocationValueLabel";
            startLocationValueLabel.Size = new Size(180, 19);
            startLocationValueLabel.TabIndex = 1;
            startLocationValueLabel.Text = "456 Warehouse Dr, Chicago";
            // 
            // trackingNumberPanel
            // 
            trackingNumberPanel.BackColor = Color.FromArgb(240, 248, 255);
            trackingNumberPanel.Controls.Add(trackingNumberLabel);
            trackingNumberPanel.Controls.Add(trackingNumberValueLabel);
            trackingNumberPanel.Location = new Point(30, 20);
            trackingNumberPanel.Name = "trackingNumberPanel";
            trackingNumberPanel.Size = new Size(300, 80);
            trackingNumberPanel.TabIndex = 0;
            // 
            // trackingNumberLabel
            // 
            trackingNumberLabel.AutoSize = true;
            trackingNumberLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            trackingNumberLabel.ForeColor = Color.FromArgb(25, 42, 86);
            trackingNumberLabel.Location = new Point(20, 15);
            trackingNumberLabel.Name = "trackingNumberLabel";
            trackingNumberLabel.Size = new Size(93, 19);
            trackingNumberLabel.TabIndex = 0;
            trackingNumberLabel.Text = "ORDER JOB#";
            // 
            // trackingNumberValueLabel
            // 
            trackingNumberValueLabel.AutoSize = true;
            trackingNumberValueLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            trackingNumberValueLabel.ForeColor = Color.FromArgb(46, 125, 50);
            trackingNumberValueLabel.Location = new Point(20, 40);
            trackingNumberValueLabel.Name = "trackingNumberValueLabel";
            trackingNumberValueLabel.Size = new Size(106, 30);
            trackingNumberValueLabel.TabIndex = 1;
            trackingNumberValueLabel.Text = "#JOB001";
            // 
            // expectedArrivalPanel
            // 
            expectedArrivalPanel.BackColor = Color.Transparent;
            expectedArrivalPanel.Controls.Add(expectedArrivalLabel);
            expectedArrivalPanel.Controls.Add(expectedArrivalValueLabel);
            expectedArrivalPanel.Location = new Point(750, 20);
            expectedArrivalPanel.Name = "expectedArrivalPanel";
            expectedArrivalPanel.Size = new Size(250, 80);
            expectedArrivalPanel.TabIndex = 1;
            // 
            // expectedArrivalLabel
            // 
            expectedArrivalLabel.AutoSize = true;
            expectedArrivalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            expectedArrivalLabel.ForeColor = Color.FromArgb(64, 64, 64);
            expectedArrivalLabel.Location = new Point(0, 20);
            expectedArrivalLabel.Name = "expectedArrivalLabel";
            expectedArrivalLabel.Size = new Size(124, 19);
            expectedArrivalLabel.TabIndex = 0;
            expectedArrivalLabel.Text = "Expected Arrival:";
            // 
            // expectedArrivalValueLabel
            // 
            expectedArrivalValueLabel.AutoSize = true;
            expectedArrivalValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            expectedArrivalValueLabel.ForeColor = Color.FromArgb(255, 152, 0);
            expectedArrivalValueLabel.Location = new Point(0, 45);
            expectedArrivalValueLabel.Name = "expectedArrivalValueLabel";
            expectedArrivalValueLabel.Size = new Size(126, 21);
            expectedArrivalValueLabel.TabIndex = 1;
            expectedArrivalValueLabel.Text = "Tomorrow 2PM";
            // 
            // noJobSelectedPanel
            // 
            noJobSelectedPanel.BackColor = Color.White;
            noJobSelectedPanel.Controls.Add(noJobSelectedLabel);
            noJobSelectedPanel.Controls.Add(selectJobPromptLabel);
            noJobSelectedPanel.Dock = DockStyle.Fill;
            noJobSelectedPanel.Location = new Point(30, 30);
            noJobSelectedPanel.Name = "noJobSelectedPanel";
            noJobSelectedPanel.Size = new Size(1039, 509);
            noJobSelectedPanel.TabIndex = 1;
            // 
            // noJobSelectedLabel
            // 
            noJobSelectedLabel.AutoSize = true;
            noJobSelectedLabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            noJobSelectedLabel.ForeColor = Color.FromArgb(200, 200, 200);
            noJobSelectedLabel.Location = new Point(400, 180);
            noJobSelectedLabel.Name = "noJobSelectedLabel";
            noJobSelectedLabel.Size = new Size(213, 86);
            noJobSelectedLabel.TabIndex = 0;
            noJobSelectedLabel.Text = "📦📍";
            noJobSelectedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectJobPromptLabel
            // 
            selectJobPromptLabel.AutoSize = true;
            selectJobPromptLabel.Font = new Font("Segoe UI", 16F);
            selectJobPromptLabel.ForeColor = Color.FromArgb(150, 150, 150);
            selectJobPromptLabel.Location = new Point(350, 290);
            selectJobPromptLabel.Name = "selectJobPromptLabel";
            selectJobPromptLabel.Size = new Size(356, 30);
            selectJobPromptLabel.TabIndex = 1;
            selectJobPromptLabel.Text = "Please select a job to track its status";
            selectJobPromptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // jobSelectionPanel
            // 
            jobSelectionPanel.BackColor = Color.White;
            jobSelectionPanel.Controls.Add(jobSelectionHeaderPanel);
            jobSelectionPanel.Controls.Add(cbJobs);
            jobSelectionPanel.Controls.Add(selectJobLabel);
            jobSelectionPanel.Controls.Add(refreshButton);
            jobSelectionPanel.Dock = DockStyle.Top;
            jobSelectionPanel.Location = new Point(0, 60);
            jobSelectionPanel.Name = "jobSelectionPanel";
            jobSelectionPanel.Size = new Size(1099, 100);
            jobSelectionPanel.TabIndex = 1;
            // 
            // jobSelectionHeaderPanel
            // 
            jobSelectionHeaderPanel.BackColor = Color.FromArgb(46, 125, 50);
            jobSelectionHeaderPanel.Controls.Add(jobSelectionLabel);
            jobSelectionHeaderPanel.Controls.Add(jobSelectionIcon);
            jobSelectionHeaderPanel.Dock = DockStyle.Top;
            jobSelectionHeaderPanel.Location = new Point(0, 0);
            jobSelectionHeaderPanel.Name = "jobSelectionHeaderPanel";
            jobSelectionHeaderPanel.Size = new Size(1099, 40);
            jobSelectionHeaderPanel.TabIndex = 3;
            // 
            // jobSelectionLabel
            // 
            jobSelectionLabel.AutoSize = true;
            jobSelectionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            jobSelectionLabel.ForeColor = Color.White;
            jobSelectionLabel.Location = new Point(50, 10);
            jobSelectionLabel.Name = "jobSelectionLabel";
            jobSelectionLabel.Size = new Size(255, 21);
            jobSelectionLabel.TabIndex = 1;
            jobSelectionLabel.Text = "Select a Job to Track its Progress";
            // 
            // jobSelectionIcon
            // 
            jobSelectionIcon.AutoSize = true;
            jobSelectionIcon.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            jobSelectionIcon.ForeColor = Color.White;
            jobSelectionIcon.Location = new Point(20, 8);
            jobSelectionIcon.Name = "jobSelectionIcon";
            jobSelectionIcon.Size = new Size(34, 25);
            jobSelectionIcon.TabIndex = 0;
            jobSelectionIcon.Text = "🔍";
            // 
            // cbJobs
            // 
            cbJobs.BackColor = Color.White;
            cbJobs.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJobs.Font = new Font("Segoe UI", 11F);
            cbJobs.ForeColor = Color.FromArgb(64, 64, 64);
            cbJobs.FormattingEnabled = true;
            cbJobs.Location = new Point(200, 55);
            cbJobs.Name = "cbJobs";
            cbJobs.Size = new Size(600, 28);
            cbJobs.TabIndex = 1;
            cbJobs.SelectedIndexChanged += cbJobs_SelectedIndexChanged;
            // 
            // selectJobLabel
            // 
            selectJobLabel.AutoSize = true;
            selectJobLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            selectJobLabel.ForeColor = Color.FromArgb(64, 64, 64);
            selectJobLabel.Location = new Point(30, 58);
            selectJobLabel.Name = "selectJobLabel";
            selectJobLabel.Size = new Size(129, 20);
            selectJobLabel.TabIndex = 0;
            selectJobLabel.Text = "Choose Your Job:";
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(25, 42, 86);
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(830, 55);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(100, 28);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "🔄 Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(25, 42, 86);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1099, 60);
            headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.None;
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(450, 14);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(239, 32);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "📍 Track Job Status";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CusTrackStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 244, 248);
            ClientSize = new Size(1099, 729);
            Controls.Add(mainContainer);
            Name = "CusTrackStatus";
            Text = "Track Status - eShift Customer Portal";
            Load += CusTrackStatus_Load;
            mainContainer.ResumeLayout(false);
            trackingContentPanel.ResumeLayout(false);
            trackingCard.ResumeLayout(false);
            progressTrackingPanel.ResumeLayout(false);
            statusLorryPanel.ResumeLayout(false);
            statusLorryPanel.PerformLayout();
            progressLinePanel.ResumeLayout(false);
            progressLine.ResumeLayout(false);
            stepsContainer.ResumeLayout(false);
            step4Panel.ResumeLayout(false);
            step4Panel.PerformLayout();
            step4Circle.ResumeLayout(false);
            step4Circle.PerformLayout();
            step3Panel.ResumeLayout(false);
            step3Panel.PerformLayout();
            step3Circle.ResumeLayout(false);
            step3Circle.PerformLayout();
            step2Panel.ResumeLayout(false);
            step2Panel.PerformLayout();
            step2Circle.ResumeLayout(false);
            step2Circle.PerformLayout();
            step1Panel.ResumeLayout(false);
            step1Panel.PerformLayout();
            step1Circle.ResumeLayout(false);
            step1Circle.PerformLayout();
            jobDetailsPanel.ResumeLayout(false);
            deliveryInfoPanel.ResumeLayout(false);
            deliveryInfoPanel.PerformLayout();
            trackingNumberPanel.ResumeLayout(false);
            trackingNumberPanel.PerformLayout();
            expectedArrivalPanel.ResumeLayout(false);
            expectedArrivalPanel.PerformLayout();
            noJobSelectedPanel.ResumeLayout(false);
            noJobSelectedPanel.PerformLayout();
            jobSelectionPanel.ResumeLayout(false);
            jobSelectionPanel.PerformLayout();
            jobSelectionHeaderPanel.ResumeLayout(false);
            jobSelectionHeaderPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainContainer;
        private Panel headerPanel;
        private Label headerLabel;
        private Panel jobSelectionPanel;
        private Label selectJobLabel;
        private ComboBox cbJobs;
        private Button refreshButton;
        private Panel jobSelectionHeaderPanel;
        private Label jobSelectionLabel;
        private Label jobSelectionIcon;
        private Panel trackingContentPanel;
        private Panel trackingCard;
        private Panel jobDetailsPanel;
        private Panel trackingNumberPanel;
        private Label trackingNumberLabel;
        private Label trackingNumberValueLabel;
        private Panel expectedArrivalPanel;
        private Label expectedArrivalLabel;
        private Label expectedArrivalValueLabel;
        private Panel deliveryInfoPanel;
        private Label startLocationLabel;
        private Label startLocationValueLabel;
        private Label destinationLabel;
        private Label destinationValueLabel;
        private Panel progressTrackingPanel;
        private Panel stepsContainer;
        private Panel step1Panel;
        private Panel step1Circle;
        private Label step1Check;
        private Label step1Icon;
        private Label step1Label;
        private Panel step2Panel;
        private Panel step2Circle;
        private Label step2Check;
        private Label step2Icon;
        private Label step2Label;
        private Panel step3Panel;
        private Panel step3Circle;
        private Label step3Check;
        private Label step3Icon;
        private Label step3Label;
        private Panel step4Panel;
        private Panel step4Circle;
        private Label step4Check;
        private Label step4Icon;
        private Label step4Label;
        private Panel progressLinePanel;
        private Panel progressLine;
        private Panel progressFill;
        private Panel statusLorryPanel;
        private Label lorryIcon;
        private Label currentLocationLabel;
        private Label estimatedArrivalLabel;
        private Panel noJobSelectedPanel;
        private Label noJobSelectedLabel;
        private Label selectJobPromptLabel;
    }
}