namespace DataLogger
{
    partial class FormToInteractiveSignal
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
            this.function = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(22, 35);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(234, 20);
            this.function.TabIndex = 0;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(274, 33);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // FormToInteractiveSignal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 103);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.function);
            this.Name = "FormToInteractiveSignal";
            this.Text = "FormToInteractiveSignal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToInteractiveSignal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormToInteractiveSignal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.Button OK;
    }
}