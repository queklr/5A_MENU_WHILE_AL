
namespace _5A_MENU_WHILE_al
{
    partial class repetir_texto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.btnrepetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingresa una palabra";
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(73, 78);
            this.txtword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(254, 26);
            this.txtword.TabIndex = 1;
            this.txtword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnrepetir
            // 
            this.btnrepetir.Location = new System.Drawing.Point(90, 125);
            this.btnrepetir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrepetir.Name = "btnrepetir";
            this.btnrepetir.Size = new System.Drawing.Size(212, 54);
            this.btnrepetir.TabIndex = 2;
            this.btnrepetir.Text = "repetir";
            this.btnrepetir.UseVisualStyleBackColor = true;
            this.btnrepetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(90, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 224);
            this.listBox1.TabIndex = 3;
            // 
            // repetir_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 434);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnrepetir);
            this.Controls.Add(this.txtword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "repetir_texto";
            this.Text = "repetir_texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Button btnrepetir;
        private System.Windows.Forms.ListBox listBox1;
    }
}