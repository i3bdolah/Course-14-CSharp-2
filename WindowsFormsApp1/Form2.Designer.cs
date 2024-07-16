namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(273, 96);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(203, 110);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Page";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDialog.Location = new System.Drawing.Point(273, 234);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(203, 110);
            this.btnShowDialog.TabIndex = 1;
            this.btnShowDialog.Text = "Show Page (Dialogue)";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialogue_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnShow);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnShowDialog;
    }
}