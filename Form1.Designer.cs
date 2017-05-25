namespace NASAapp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAddNewLocation = new System.Windows.Forms.Panel();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tbAddNewLocationResult = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.buttonAddNewLocation = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelStart = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.panelAddNewLocation.SuspendLayout();
            this.panelAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddNewLocation
            // 
            this.panelAddNewLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelAddNewLocation.Controls.Add(this.progressBarLoading);
            this.panelAddNewLocation.Controls.Add(this.textBox8);
            this.panelAddNewLocation.Controls.Add(this.btnOK);
            this.panelAddNewLocation.Controls.Add(this.btnCancel);
            this.panelAddNewLocation.Controls.Add(this.textBox2);
            this.panelAddNewLocation.Controls.Add(this.listBox2);
            this.panelAddNewLocation.Controls.Add(this.tbAddNewLocationResult);
            this.panelAddNewLocation.Location = new System.Drawing.Point(191, 12);
            this.panelAddNewLocation.Name = "panelAddNewLocation";
            this.panelAddNewLocation.Size = new System.Drawing.Size(595, 330);
            this.panelAddNewLocation.TabIndex = 2;
            this.panelAddNewLocation.Visible = false;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(3, 170);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(100, 23);
            this.progressBarLoading.TabIndex = 9;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox8.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox8.Location = new System.Drawing.Point(3, 124);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(95, 17);
            this.textBox8.TabIndex = 4;
            this.textBox8.Text = "Add country:";
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(13, 239);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 36);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(13, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(3, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(68)))));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(109, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(483, 274);
            this.listBox2.TabIndex = 7;
            // 
            // tbAddNewLocationResult
            // 
            this.tbAddNewLocationResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.tbAddNewLocationResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddNewLocationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddNewLocationResult.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAddNewLocationResult.Location = new System.Drawing.Point(109, 20);
            this.tbAddNewLocationResult.Margin = new System.Windows.Forms.Padding(0);
            this.tbAddNewLocationResult.Name = "tbAddNewLocationResult";
            this.tbAddNewLocationResult.Size = new System.Drawing.Size(284, 20);
            this.tbAddNewLocationResult.TabIndex = 8;
            this.tbAddNewLocationResult.Text = "Nearby landslides:";
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(0, 136);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(179, 46);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "Information";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseHover += new System.EventHandler(this.btnAbout_MouseHover);
            // 
            // buttonAddNewLocation
            // 
            this.buttonAddNewLocation.FlatAppearance.BorderSize = 0;
            this.buttonAddNewLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.buttonAddNewLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.buttonAddNewLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAddNewLocation.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewLocation.Location = new System.Drawing.Point(0, 182);
            this.buttonAddNewLocation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNewLocation.Name = "buttonAddNewLocation";
            this.buttonAddNewLocation.Size = new System.Drawing.Size(179, 46);
            this.buttonAddNewLocation.TabIndex = 3;
            this.buttonAddNewLocation.Text = "Add new location";
            this.buttonAddNewLocation.UseVisualStyleBackColor = true;
            this.buttonAddNewLocation.Click += new System.EventHandler(this.buttonAddNewLocation_Click);
            this.buttonAddNewLocation.MouseHover += new System.EventHandler(this.buttonAddNewLocation_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelAbout.Controls.Add(this.pictureBox1);
            this.panelAbout.Controls.Add(this.textBox1);
            this.panelAbout.Location = new System.Drawing.Point(191, 12);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(595, 330);
            this.panelAbout.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(13, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(571, 324);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(206)))), ((int)(((byte)(108)))));
            this.panelStart.Controls.Add(this.pictureBox2);
            this.panelStart.ForeColor = System.Drawing.Color.White;
            this.panelStart.Location = new System.Drawing.Point(191, 12);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(595, 330);
            this.panelStart.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 324);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 800;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(787, 354);
            this.Controls.Add(this.buttonAddNewLocation);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelAddNewLocation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Be Informed, Save Yourself!";
            this.panelAddNewLocation.ResumeLayout(false);
            this.panelAddNewLocation.PerformLayout();
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelAddNewLocation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button buttonAddNewLocation;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox tbAddNewLocationResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}

