namespace ExtensibilityProject2
{
    partial class PriCustomTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_cv1 = new System.Windows.Forms.Label();
            this.label_cv2 = new System.Windows.Forms.Label();
            this.label_cv3 = new System.Windows.Forms.Label();
            this.tb_cv1 = new System.Windows.Forms.TextBox();
            this.tb_cv2 = new System.Windows.Forms.TextBox();
            this.tb_cv3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_cv1
            // 
            this.label_cv1.AutoSize = true;
            this.label_cv1.Location = new System.Drawing.Point(76, 74);
            this.label_cv1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cv1.Name = "label_cv1";
            this.label_cv1.Size = new System.Drawing.Size(79, 16);
            this.label_cv1.TabIndex = 0;
            this.label_cv1.Text = "CampoVar1";
            // 
            // label_cv2
            // 
            this.label_cv2.AutoSize = true;
            this.label_cv2.Location = new System.Drawing.Point(76, 114);
            this.label_cv2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cv2.Name = "label_cv2";
            this.label_cv2.Size = new System.Drawing.Size(79, 16);
            this.label_cv2.TabIndex = 1;
            this.label_cv2.Text = "CampoVar2";
            // 
            // label_cv3
            // 
            this.label_cv3.AutoSize = true;
            this.label_cv3.Location = new System.Drawing.Point(76, 156);
            this.label_cv3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cv3.Name = "label_cv3";
            this.label_cv3.Size = new System.Drawing.Size(79, 16);
            this.label_cv3.TabIndex = 2;
            this.label_cv3.Text = "CampoVar3";
            // 
            // tb_cv1
            // 
            this.tb_cv1.Location = new System.Drawing.Point(167, 70);
            this.tb_cv1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cv1.Name = "tb_cv1";
            this.tb_cv1.Size = new System.Drawing.Size(311, 22);
            this.tb_cv1.TabIndex = 3;
            // 
            // tb_cv2
            // 
            this.tb_cv2.Location = new System.Drawing.Point(167, 111);
            this.tb_cv2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cv2.Name = "tb_cv2";
            this.tb_cv2.Size = new System.Drawing.Size(311, 22);
            this.tb_cv2.TabIndex = 4;
            // 
            // tb_cv3
            // 
            this.tb_cv3.Location = new System.Drawing.Point(167, 156);
            this.tb_cv3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_cv3.Name = "tb_cv3";
            this.tb_cv3.Size = new System.Drawing.Size(311, 22);
            this.tb_cv3.TabIndex = 5;
            // 
            // PriCustomTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_cv3);
            this.Controls.Add(this.tb_cv2);
            this.Controls.Add(this.tb_cv1);
            this.Controls.Add(this.label_cv3);
            this.Controls.Add(this.label_cv2);
            this.Controls.Add(this.label_cv1);
            this.Name = "PriCustomTab";
            this.Size = new System.Drawing.Size(571, 250);
            this.TabCaption = "Mais Campos";
            this.Loading += new Primavera.Extensibility.Patterns.CustomTab.EventDelegate(this.PriCustomTab1_Loading);
            this.Saving += new Primavera.Extensibility.Patterns.CustomTab.EventDelegate(this.PriCustomTab1_Saving);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cv1;
        private System.Windows.Forms.Label label_cv2;
        private System.Windows.Forms.Label label_cv3;
        private System.Windows.Forms.TextBox tb_cv1;
        private System.Windows.Forms.TextBox tb_cv2;
        private System.Windows.Forms.TextBox tb_cv3;
    }
}
