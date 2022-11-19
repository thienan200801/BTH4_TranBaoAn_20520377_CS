namespace Bai01
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
            this.label_Event = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Event
            // 
            this.label_Event.AutoSize = true;
            this.label_Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Event.Location = new System.Drawing.Point(242, 273);
            this.label_Event.Name = "label_Event";
            this.label_Event.Size = new System.Drawing.Size(266, 39);
            this.label_Event.TabIndex = 0;
            this.label_Event.Text = "Sự kiện               ";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_value.ForeColor = System.Drawing.Color.Red;
            this.label_value.Location = new System.Drawing.Point(242, 322);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(251, 39);
            this.label_value.TabIndex = 1;
            this.label_value.Text = "Giá trị                ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 641);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label_Event);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Event;
        private System.Windows.Forms.Label label_value;
    }
}

