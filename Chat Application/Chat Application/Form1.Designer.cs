namespace Chat_Application
{
    partial class Form1
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
            this.serverporttextbox = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.serveriptextbox = new System.Windows.Forms.TextBox();
            this.startutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientporttextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientiptextbox = new System.Windows.Forms.TextBox();
            this.connectbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.chatscreentextbox = new System.Windows.Forms.TextBox();
            this.messagescreentextbox = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverporttextbox
            // 
            this.serverporttextbox.Location = new System.Drawing.Point(364, 67);
            this.serverporttextbox.Name = "serverporttextbox";
            this.serverporttextbox.Size = new System.Drawing.Size(39, 20);
            this.serverporttextbox.TabIndex = 14;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(312, 71);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(57, 13);
            this.Port.TabIndex = 13;
            this.Port.Text = "serverport:";
            // 
            // serveriptextbox
            // 
            this.serveriptextbox.Location = new System.Drawing.Point(233, 68);
            this.serveriptextbox.Name = "serveriptextbox";
            this.serveriptextbox.Size = new System.Drawing.Size(73, 20);
            this.serveriptextbox.TabIndex = 12;
            this.serveriptextbox.TextChanged += new System.EventHandler(this.Serveriptextbox_TextChanged);
            // 
            // startutton
            // 
            this.startutton.Location = new System.Drawing.Point(409, 67);
            this.startutton.Name = "startutton";
            this.startutton.Size = new System.Drawing.Size(75, 23);
            this.startutton.TabIndex = 11;
            this.startutton.Text = "START";
            this.startutton.UseVisualStyleBackColor = true;
            this.startutton.Click += new System.EventHandler(this.Startutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "serverHost";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // clientporttextbox
            // 
            this.clientporttextbox.Location = new System.Drawing.Point(364, 145);
            this.clientporttextbox.Name = "clientporttextbox";
            this.clientporttextbox.Size = new System.Drawing.Size(39, 20);
            this.clientporttextbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "clientport:";
            // 
            // clientiptextbox
            // 
            this.clientiptextbox.Location = new System.Drawing.Point(233, 145);
            this.clientiptextbox.Name = "clientiptextbox";
            this.clientiptextbox.Size = new System.Drawing.Size(73, 20);
            this.clientiptextbox.TabIndex = 17;
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(409, 144);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 23);
            this.connectbutton.TabIndex = 16;
            this.connectbutton.Text = "CONNECT";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "clientHost:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // chatscreentextbox
            // 
            this.chatscreentextbox.Location = new System.Drawing.Point(198, 195);
            this.chatscreentextbox.Multiline = true;
            this.chatscreentextbox.Name = "chatscreentextbox";
            this.chatscreentextbox.Size = new System.Drawing.Size(431, 102);
            this.chatscreentextbox.TabIndex = 20;
            // 
            // messagescreentextbox
            // 
            this.messagescreentextbox.Location = new System.Drawing.Point(198, 313);
            this.messagescreentextbox.Multiline = true;
            this.messagescreentextbox.Name = "messagescreentextbox";
            this.messagescreentextbox.Size = new System.Drawing.Size(310, 59);
            this.messagescreentextbox.TabIndex = 21;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(536, 313);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 59);
            this.sendbutton.TabIndex = 22;
            this.sendbutton.Text = "SEND";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.messagescreentextbox);
            this.Controls.Add(this.chatscreentextbox);
            this.Controls.Add(this.clientporttextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientiptextbox);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serverporttextbox);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.serveriptextbox);
            this.Controls.Add(this.startutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverporttextbox;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.TextBox serveriptextbox;
        private System.Windows.Forms.Button startutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientporttextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientiptextbox;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox chatscreentextbox;
        private System.Windows.Forms.TextBox messagescreentextbox;
        private System.Windows.Forms.Button sendbutton;
    }
}

