namespace numero_extenso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txnumero = new System.Windows.Forms.TextBox();
            this.btextenso = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.txextenso = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txnumero
            // 
            this.txnumero.Location = new System.Drawing.Point(72, 21);
            this.txnumero.Name = "txnumero";
            this.txnumero.Size = new System.Drawing.Size(368, 23);
            this.txnumero.TabIndex = 1;
            // 
            // btextenso
            // 
            this.btextenso.Location = new System.Drawing.Point(15, 314);
            this.btextenso.Name = "btextenso";
            this.btextenso.Size = new System.Drawing.Size(125, 39);
            this.btextenso.TabIndex = 3;
            this.btextenso.Text = "Extenso";
            this.btextenso.UseVisualStyleBackColor = true;
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(146, 314);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(125, 39);
            this.btlimpar.TabIndex = 4;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // txextenso
            // 
            this.txextenso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txextenso.Location = new System.Drawing.Point(15, 64);
            this.txextenso.Name = "txextenso";
            this.txextenso.Size = new System.Drawing.Size(425, 244);
            this.txextenso.TabIndex = 2;
            this.txextenso.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.Controls.Add(this.txextenso);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btextenso);
            this.Controls.Add(this.txnumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txnumero;
        private System.Windows.Forms.Button btextenso;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.RichTextBox txextenso;
    }
}

