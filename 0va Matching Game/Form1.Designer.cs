namespace _0va_Matching_Game
{
    partial class UserProfile
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
            this.button1 = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Salutations = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.First_Name_Error = new System.Windows.Forms.Label();
            this.Last_Name_Error = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(335, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstName
            // 
            this.FirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstName.Location = new System.Drawing.Point(319, 171);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(166, 20);
            this.FirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, -62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 206);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Profile";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 106);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome :";
            // 
            // Salutations
            // 
            this.Salutations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Salutations.FormattingEnabled = true;
            this.Salutations.Items.AddRange(new object[] {
            "",
            "Ms",
            "Mr"});
            this.Salutations.Location = new System.Drawing.Point(214, 170);
            this.Salutations.Name = "Salutations";
            this.Salutations.Size = new System.Drawing.Size(97, 21);
            this.Salutations.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 61);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salutation*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 61);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name*";
            // 
            // First_Name_Error
            // 
            this.First_Name_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.First_Name_Error.AutoSize = true;
            this.First_Name_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_Name_Error.Location = new System.Drawing.Point(332, 194);
            this.First_Name_Error.Name = "First_Name_Error";
            this.First_Name_Error.Size = new System.Drawing.Size(0, 13);
            this.First_Name_Error.TabIndex = 7;
            // 
            // Last_Name_Error
            // 
            this.Last_Name_Error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Last_Name_Error.AutoSize = true;
            this.Last_Name_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_Name_Error.Location = new System.Drawing.Point(506, 194);
            this.Last_Name_Error.Name = "Last_Name_Error";
            this.Last_Name_Error.Size = new System.Drawing.Size(0, 13);
            this.Last_Name_Error.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria Math", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 61);
            this.label6.TabIndex = 9;
            this.label6.Text = "Last Name*";
            // 
            // LastName
            // 
            this.LastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastName.Location = new System.Drawing.Point(493, 171);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(166, 20);
            this.LastName.TabIndex = 8;
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.Location = new System.Drawing.Point(90, 253);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(126, 33);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Last_Name_Error);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.First_Name_Error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salutations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.button1);
            this.Name = "UserProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Salutations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label First_Name_Error;
        private System.Windows.Forms.Label Last_Name_Error;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button Reset;
    }
}

