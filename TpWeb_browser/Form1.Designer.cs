
namespace TpWeb_browser
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btndroite = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnstop);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnactualiser);
            this.panel1.Controls.Add(this.btndroite);
            this.panel1.Controls.Add(this.btnretour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnstop
            // 
            this.btnstop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstop.BackgroundImage")));
            this.btnstop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(1276, 4);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(47, 80);
            this.btnstop.TabIndex = 4;
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1119, 44);
            this.textBox1.TabIndex = 3;
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnactualiser.BackgroundImage")));
            this.btnactualiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.Location = new System.Drawing.Point(87, 3);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(47, 80);
            this.btnactualiser.TabIndex = 2;
            this.btnactualiser.UseVisualStyleBackColor = true;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btndroite
            // 
            this.btndroite.BackgroundImage = global::TpWeb_browser.Properties.Resources.suivant;
            this.btndroite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndroite.Location = new System.Drawing.Point(45, 3);
            this.btndroite.Name = "btndroite";
            this.btndroite.Size = new System.Drawing.Size(42, 80);
            this.btndroite.TabIndex = 1;
            this.btndroite.UseVisualStyleBackColor = true;
            this.btndroite.Click += new System.EventHandler(this.btndroite_Click);
            // 
            // btnretour
            // 
            this.btnretour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnretour.BackgroundImage")));
            this.btnretour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretour.Location = new System.Drawing.Point(3, 3);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(42, 80);
            this.btnretour.TabIndex = 0;
            this.btnretour.UseVisualStyleBackColor = true;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 86);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(1380, 734);
            this.chromiumWebBrowser1.TabIndex = 1;
            this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 820);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnactualiser;
        private System.Windows.Forms.Button btndroite;
        private System.Windows.Forms.Button btnretour;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Button btnstop;
    }
}

