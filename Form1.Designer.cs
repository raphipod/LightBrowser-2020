using System;

namespace LightBrowser_2020
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(125, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(663, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1KeyPress);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoSize = true;
            this.pContainer.Location = new System.Drawing.Point(-1, 35);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(802, 416);
            this.pContainer.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(8, 3);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 28);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.BackColor = System.Drawing.Color.Silver;
            this.btnFwd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwd.ForeColor = System.Drawing.Color.Transparent;
            this.btnFwd.Image = ((System.Drawing.Image)(resources.GetObject("btnFwd.Image")));
            this.btnFwd.Location = new System.Drawing.Point(37, 3);
            this.btnFwd.Margin = new System.Windows.Forms.Padding(2);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(34, 28);
            this.btnFwd.TabIndex = 4;
            this.btnFwd.UseVisualStyleBackColor = false;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Silver;
            this.btnReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReload.BackgroundImage")));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(74, 1);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(46, 32);
            this.btnReload.TabIndex = 6;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " LightBrowser 2020.12";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnReload;
    }
}

