namespace TP_MOD3_1302213092
{
    partial class Welcome
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
            btnClickThis = new Button();
            label1 = new Label();
            txtNama = new TextBox();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(195, 55);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(94, 29);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Click This";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 25);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 1;
            label1.Text = "Masukkan Nama:";
            label1.Click += label1_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(251, 22);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(177, 27);
            txtNama.TabIndex = 2;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 110);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Controls.Add(btnClickThis);
            Name = "Welcome";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label label1;
        private TextBox txtNama;
    }
}