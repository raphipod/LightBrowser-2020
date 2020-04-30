using System;

namespace LightBrowser_2020
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.btnEcosia = new System.Windows.Forms.Button();
            this.btnYouTube = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(112, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(844, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(964, 6);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 47);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Go!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoSize = true;
            this.pContainer.Location = new System.Drawing.Point(-1, 55);
            this.pContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1068, 501);
            this.pContainer.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 47);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Location = new System.Drawing.Point(73, 6);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(32, 47);
            this.btnFwd.TabIndex = 4;
            this.btnFwd.Text = ">";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(52, 16);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(15, 26);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "R";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoogle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGoogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F);
            this.btnGoogle.Location = new System.Drawing.Point(881, 29);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(75, 24);
            this.btnGoogle.TabIndex = 7;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = false;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // btnEcosia
            // 
            this.btnEcosia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEcosia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEcosia.Location = new System.Drawing.Point(800, 29);
            this.btnEcosia.Name = "btnEcosia";
            this.btnEcosia.Size = new System.Drawing.Size(75, 24);
            this.btnEcosia.TabIndex = 8;
            this.btnEcosia.Text = "Ecosia";
            this.btnEcosia.UseVisualStyleBackColor = false;
            this.btnEcosia.Click += new System.EventHandler(this.btnEcosia_Click);
            // 
            // btnYouTube
            // 
            this.btnYouTube.BackColor = System.Drawing.Color.Red;
            this.btnYouTube.ForeColor = System.Drawing.Color.Black;
            this.btnYouTube.Location = new System.Drawing.Point(112, 29);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Size = new System.Drawing.Size(75, 24);
            this.btnYouTube.TabIndex = 9;
            this.btnYouTube.Text = "YouTube";
            this.btnYouTube.UseVisualStyleBackColor = false;
            this.btnYouTube.Click += new System.EventHandler(this.btnYouTube_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 24);
            this.button1.TabIndex = 10;
            this.button1.Text = "Wikipedia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYouTube);
            this.Controls.Add(this.btnEcosia);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " LightBrowser 2020.04";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnGoogle;
        private System.Windows.Forms.Button btnEcosia;
        private System.Windows.Forms.Button btnYouTube;
        private System.Windows.Forms.Button button1;
    }
}

