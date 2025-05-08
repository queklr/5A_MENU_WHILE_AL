
namespace _5A_MENU_WHILE_al
{
    partial class pares_e_impares
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
            this.btnpares = new System.Windows.Forms.Button();
            this.btnimpares = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnpares
            // 
            this.btnpares.Location = new System.Drawing.Point(93, 52);
            this.btnpares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnpares.Name = "btnpares";
            this.btnpares.Size = new System.Drawing.Size(112, 35);
            this.btnpares.TabIndex = 0;
            this.btnpares.Text = "pares";
            this.btnpares.UseVisualStyleBackColor = true;
            this.btnpares.Click += new System.EventHandler(this.btnpares_Click);
            // 
            // btnimpares
            // 
            this.btnimpares.Location = new System.Drawing.Point(93, 120);
            this.btnimpares.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnimpares.Name = "btnimpares";
            this.btnimpares.Size = new System.Drawing.Size(112, 35);
            this.btnimpares.TabIndex = 1;
            this.btnimpares.Text = "impares";
            this.btnimpares.UseVisualStyleBackColor = true;
            this.btnimpares.Click += new System.EventHandler(this.btnimpares_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(93, 197);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 144);
            this.listBox1.TabIndex = 2;
            // 
            // pares_e_impares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 410);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnimpares);
            this.Controls.Add(this.btnpares);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pares_e_impares";
            this.Text = "pares_e_impares";
            this.Load += new System.EventHandler(this.pares_e_impares_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpares;
        private System.Windows.Forms.Button btnimpares;
        private System.Windows.Forms.ListBox listBox1;
    }
}